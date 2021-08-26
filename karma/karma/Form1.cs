using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace karma
{
    public partial class karma_main_form : Form
    {
        public void isTodayMeeting()
        {
            //checking if today is in meetings dates and 
            //if there is meeting today :it creates new meeting date in database
            //if there isn't meeting : disable the button attendence_search_button and text box


            adapt = new SqlDataAdapter("USE karma;SELECT * FROM  meetings WHERE meetings_date = '" + DateTime.Today + "'; ", con);
            //clear dt to use it again in the method
            dt.Clear();
            adapt.Fill(dt);
            //if the today date not in the database ask the user to add today date as meeting date to database
            if (dt.Rows.Count == 0)
            {
                //pop up meesage box to check if today is meeting or not
                string messageBox_content = "هل اليوم هو اجتماع؟";
                string messageBox_title = "التأكد من يوم الاجتماع";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //if it is meeting
                DialogResult result = MessageBox.Show(messageBox_content, messageBox_title, buttons);
                if (result == DialogResult.Yes)
                {
                    k270:
                    //pop up meesage box to make sure of the date in laptop to create new meeting
                    messageBox_content = "هل انت متأكد من تاريخ اليوم هو "+DateTime.Today.ToShortDateString();
                    messageBox_title = "  التأكد من التاريخ على الاب توب";
                    result = MessageBox.Show(messageBox_content, messageBox_title, buttons);
                    //if it is right date 
                    
                    if (result == DialogResult.Yes)
                    {
                        //create new meeting with today date
                        cmd = new SqlCommand("INSERT INTO meetings (meetings_date) VALUES('" + DateTime.Today+ "');", con);
                        cmd.ExecuteNonQuery();
                        enable_attendence();
                    }
                    else
                    {
                        //if the date in laptop pop up message box to warn the user
                        result =MessageBox.Show("حسنا قم بتعديل تاريخ اليوم","تعديل  التاريخ على الاب توب",MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            //and go to k70 to ask him about the date again
                            goto k270;
                        }
                        else
                        {
                            //if the user clicked on cancel
                            //call disable funcion
                            disable_attendence();
                        }
                        
                    }
                }
                else
                {
                    //if today is not meeting 
                    //call disable function
                    disable_attendence();
                }
            }
            }

        public void disable_attendence()
        {
            //this function has been made to disable the button and text box of the attendence and show up button and lable 
            attendence_noMeeting_label.Visible = true;
            attendence_search_button.Enabled = false;
            attendence_search_textBox.Enabled = false;
            attendence_todayIsMeeting_button.Visible = true;
        }
        public void enable_attendence()
        {
            //this function has been made to enable the button and text box of the attendence and hide the button and the lable 
            attendence_noMeeting_label.Visible = false;
            attendence_search_button.Enabled = true;
            attendence_search_textBox.Enabled = true;
            attendence_todayIsMeeting_button.Visible = false;
        }
        public void autocomplete_textBox_tool()
        {
            //autocomplete text box with the names of the served to help user with names
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            attendence_search_textBox.AutoCompleteCustomSource = col;
            dt.Clear();
            cmd = new SqlCommand("USE karma;SELECT * FROM served ;", con);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //add served names to auto complete list
                col.Add(dt.Rows[i]["served_name"].ToString());
            }
        }



        //some gobal variables 
        public static int served_id;
        public static int meetings_id;
        public static string served_name;


        //setup the connection variables 
        SqlConnection con = new SqlConnection("data source=DESKTOP-IJGDPND\\SQL_EXPRESS1;initial catalog=master;trusted_connection=true");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataAdapter adapt = new SqlDataAdapter();

        public karma_main_form()
        {

            //open the connection
            con.Open();

            //creating the form
            InitializeComponent();

            //checking if today is in meetings dates and 
            //if there is meeting today :it creates new meeting date in database
            //if there isn't meeting : disable the button and textbox of attendence page
            isTodayMeeting();

            //autocomplete text box with the names of the served
            autocomplete_textBox_tool();

        }

        private void attendence_panel_correct_Paint(object sender, PaintEventArgs e)
        {

        }            
        private void attendence_search_textBox_TextChanged(object sender, EventArgs e)
        {
            attendence_attended_panel.Visible = false;
        }

        private void attendence_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void attendence_todayIsMeeting_button_Click(object sender, EventArgs e)
        {
            isTodayMeeting();
        }

        private void attendence_search_button_Click(object sender, EventArgs e)
        {
            //fetch meeting id by today date
            cmd = new SqlCommand("SELECT *FROM meetings WHERE meetings_date ='" + DateTime.Today.ToShortDateString() + "';", con);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            dt.Clear();
            adapt.Fill(dt);
            meetings_id = Convert.ToInt16(dt.Rows[0]["meetings_id"]);


            //make sure that text box is not empty
            if (attendence_search_textBox.Text != string.Empty)
            {

                //check if the text box value is name or id number
                if (Convert.ToInt16(attendence_search_textBox.Text[0]) >= 48 && Convert.ToInt16(attendence_search_textBox.Text[0]) <= 57)
                {
                    //fetch served_name and served_id
                    cmd = new SqlCommand("SELECT * FROM served WHERE served_id ='" +Convert.ToInt16(attendence_search_textBox.Text)+ "';", con);
                    cmd.ExecuteNonQuery();
                    adapt = new SqlDataAdapter(cmd);
                    dt.Clear();
                    adapt.Fill(dt);
                    served_id = Convert.ToInt16(dt.Rows[0]["served_id"]);
                    served_name = dt.Rows[0]["served_name"].ToString();

                    if (dt.Rows.Count > 0)
                    {
                        //check if served attended before or not
                        cmd = new SqlCommand("SELECT * FROM attend WHERE served_id =" + served_id + "and meetings_id="+meetings_id+";", con);
                        cmd.ExecuteNonQuery();
                        adapt = new SqlDataAdapter(cmd);
                        dt.Clear();
                        adapt.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            cmd = new SqlCommand("INSERT INTO attend (served_id,meetings_id)VALUES(@s_id,@m_id);", con);
                            cmd.Parameters.AddWithValue("@s_id", served_id);
                            cmd.Parameters.AddWithValue("@m_id", meetings_id);
                            cmd.ExecuteNonQuery();

                            //set up attended panel
                            attendence_search_textBox.Text = string.Empty;
                            attendence_attended_panel.Visible = true;
                            attendence_id_variable_label.Text = Convert.ToString(served_id);
                            attendence_variable_name_label.Text = served_name;
                        }
                        else
                        {
                            MessageBox.Show("تم حضور "+served_name+" من قبل ");
                            attendence_search_textBox.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM served WHERE served_name Like'%" + attendence_search_textBox.Text + "%';", con);
                    cmd.ExecuteNonQuery();
                    adapt = new SqlDataAdapter(cmd);
                    dt.Clear();
                    adapt.Fill(dt);

                    

                    if (dt.Rows.Count == 1)
                    {
                        served_id = Convert.ToInt16(dt.Rows[0]["served_id"]);
                        served_name = dt.Rows[0]["served_name"].ToString();
                        //check if served attended before or not
                        cmd = new SqlCommand("SELECT * FROM attend WHERE served_id =" + served_id + "and meetings_id=" + meetings_id + ";", con);
                        cmd.ExecuteNonQuery();
                        adapt = new SqlDataAdapter(cmd);
                        dt.Clear();
                        adapt.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            cmd = new SqlCommand("INSERT INTO attend (served_id,meetings_id)VALUES(@s_id,@m_id);", con);
                            cmd.Parameters.AddWithValue("@s_id", Convert.ToInt16(served_id));
                            cmd.Parameters.AddWithValue("@m_id", Convert.ToInt16(meetings_id));
                            cmd.ExecuteNonQuery();

                            //set up attended panel
                            attendence_search_textBox.Text = string.Empty;
                            attendence_attended_panel.Visible = true;
                            attendence_id_variable_label.Text = Convert.ToString(served_id);
                            attendence_variable_name_label.Text = served_name;
                        }
                        else
                        {
                            MessageBox.Show("تم حضور هذا الاسم من قبل");
                            attendence_search_textBox.Text = string.Empty;
                        }
                    }

                }
            }
            //cmd =new SqlCommand("SELECT * FROM served WHERE name")
        }

        private void attendence_cancelAttendence_button_Click(object sender, EventArgs e)
        {
            //cancel the attendence button
            cmd = new SqlCommand("DELETE FROM attend WHERE served_id=@s_id and meetings_id=@m_id;", con);
            cmd.Parameters.AddWithValue("@s_id",served_id);
            cmd.Parameters.AddWithValue("@m_id", meetings_id);
            cmd.ExecuteNonQuery();
            attendence_attended_panel.Visible = false;
        }
    }
}
