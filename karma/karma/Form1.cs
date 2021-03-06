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
using WinFormAnimation;
using CircularProgressBar;

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
            report_served_showResult_textBox.AutoCompleteCustomSource = col;
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
        public static string served_confession_father;
        public static DateTime served_birthday;
        public static string served_phone;
        public static string served_grade;



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

            //default selected items in add page
            add_grade_comboBox.SelectedIndex = 0;
            add_father_comboBox.SelectedIndex = 0;


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

        private void add_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_newServed_button_Click(object sender, EventArgs e)
        {
            //reset all warning labels to be hiden
            add_nameWarning_label.Visible = false;
            add_phoneWarning_label.Visible = false;
            add_dateWarning_label.Visible = false;
            bool nameCheckerBoolean = false, phoneCheckerBoolean = false, dateCheckerBoolean = false;

            //validation fileds to add its to database
            if (!(add_name_textBox.Text.All(char.IsLetter))||add_name_textBox.Text==string.Empty)
            {
                nameCheckerBoolean = true;
            }
            if (add_phone_textBox.Text == string.Empty ||!(add_phone_textBox.Text.Length==11))
            {
                phoneCheckerBoolean = true;
            }
            if(add_birthday_dateTimePicker.Text== "Thursday, August 30, 2001")
            {
                dateCheckerBoolean = true;
            }
            
            //if there is any problem with the validation
            //goto k270 
            if(nameCheckerBoolean||phoneCheckerBoolean||dateCheckerBoolean)
                goto k270;
            //adding data to system
            cmd = new SqlCommand("INSERT INTO served (served_name,served_phone,served_grade,served_confession_father,served_birthday) VALUES (@name,@phone,@grade,@father,@date);",con);
            cmd.Parameters.AddWithValue("@name",add_name_textBox.Text);
            cmd.Parameters.AddWithValue("@phone",add_phone_textBox.Text);
            cmd.Parameters.AddWithValue("@grade",add_grade_comboBox.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@father",add_father_comboBox.Text);
            cmd.Parameters.AddWithValue("@date",add_birthday_dateTimePicker.Value);
            cmd.ExecuteNonQuery();
            //show up add successfuly and clear the fileds from data
            MessageBox.Show("تم اضافة " + add_name_textBox.Text + " بنجاح");
            add_name_textBox.Text = string.Empty;
            add_phone_textBox.Text = string.Empty;
            add_grade_comboBox.SelectedIndex = 0;
            add_birthday_dateTimePicker.Value = Convert.ToDateTime("Thursday, August 30, 2001");
            add_father_comboBox.SelectedIndex = 0;


            //clear the filed with problem and appear red warning close of it
            k270:
            if (nameCheckerBoolean)
            {
                add_name_textBox.Text = string.Empty;
                add_nameWarning_label.Visible = true;

            }
            if (phoneCheckerBoolean)
            {
                add_phone_textBox.Text = string.Empty;
                add_phoneWarning_label.Visible = true;
            }
            if (dateCheckerBoolean)
            {
                add_dateWarning_label.Visible = true;
            }



        }

        private void report_period_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void report_Period_main_label_Click(object sender, EventArgs e)
        {

        }

        private void report_period_choosePeriod_label_Click(object sender, EventArgs e)
        {

        }

        private void karma_main_form_Load(object sender, EventArgs e)
        {

        }

        private void report_served_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void report_served_details_tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void report_served_details_id_label_Click(object sender, EventArgs e)
        {

        }

        private void report_served_details_name_label_Click(object sender, EventArgs e)
        {

        }

        private void report_served_details_main_label_Click(object sender, EventArgs e)
        {

        }

        private void report_served_showResult_button_Click(object sender, EventArgs e)
        {
            
            //make sure that text box is not empty
            if (report_served_showResult_textBox.Text != string.Empty)
            {
                
                //check if the text box value is name or id number
                if (Convert.ToInt16(report_served_showResult_textBox.Text[0]) >= 48 && Convert.ToInt16(report_served_showResult_textBox.Text[0]) <= 57)
                {
                    
                    //fetch served_name and served_id
                    cmd = new SqlCommand("SELECT * FROM served WHERE served_id ='" + Convert.ToInt16(report_served_showResult_textBox.Text) + "';", con);
                    cmd.ExecuteNonQuery();
                    adapt = new SqlDataAdapter(cmd);
                    dt.Clear();
                    adapt.Fill(dt);
                    served_id = Convert.ToInt16(dt.Rows[0]["served_id"]);
                    served_name = dt.Rows[0]["served_name"].ToString();
                    served_confession_father = dt.Rows[0]["served_confession_father"].ToString();
                    served_birthday = Convert.ToDateTime(dt.Rows[0]["served_birthday"]);
                    served_grade = (Convert.ToInt16(dt.Rows[0]["served_grade"]) == 1) ? "الاول" : (Convert.ToInt16(dt.Rows[0]["served_grade"]) == 2)? "الثانى":"الثالث";
                    
                    
                    

                    if (dt.Rows.Count > 0)
                    {

                        //giving values to items of the page
                        report_served_details_variableDate_label.Text = served_birthday.ToShortDateString();
                        report_served_details_variableFather_label.Text = served_confession_father;
                        report_served_details_variableId_label.Text = Convert.ToString(served_id);
                        report_served_details_variableName_label.Text = served_name;
                        report_served_details_variablePhone_label.Text = served_phone;
                        report_served_details_variableGrade_label.Text = served_grade;

                        //showing up the items of the page
                        report_served_weeksDetails_dataGridView.Visible = true;
                        report_served_attendence_circularProgressBar.Visible = true;
                        report_served_attendence_label.Visible = true;
                        report_served_details_tableLayoutPanel.Visible = true;
                        report_served_weeksDetails_label.Visible = true;

                        
                        cmd = new SqlCommand("SELECT attendence_date  as 'وقت و تاريخ الحضور'FROM attend where served_id= " + served_id + ";", con);
                        cmd.ExecuteNonQuery();
                        adapt = new SqlDataAdapter(cmd);
                        dt.Columns.Clear();
                        dt.Clear();

                        adapt.Fill(dt);
                        DataTable dtCloned = new DataTable();
                        dtCloned.Columns.Add("تاريخ الاجتماع",typeof(DateTime));
                        dtCloned.Columns.Add("وقت الحضور", typeof(string));
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            
                            dtCloned.Rows.Add(Convert.ToDateTime(dt.Rows[i].ItemArray[0].ToString()).ToShortDateString(), Convert.ToDateTime(dt.Rows[i].ItemArray[0].ToString()).ToString("hh:mm tt"));
                        }
                        report_served_weeksDetails_dataGridView.DataSource = dtCloned;
                        
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
            
                }
    }
}
