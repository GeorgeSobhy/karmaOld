namespace karma
{
    partial class karma_main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attendence_panel = new System.Windows.Forms.Panel();
            this.attendence_todayIsMeeting_button = new System.Windows.Forms.Button();
            this.attendence_noMeeting_label = new System.Windows.Forms.Label();
            this.attendence_attended_panel = new System.Windows.Forms.Panel();
            this.attendence_cancelAttendence_button = new System.Windows.Forms.Button();
            this.attendence_variable_name_label = new System.Windows.Forms.Label();
            this.attendence_id_variable_label = new System.Windows.Forms.Label();
            this.attendence_label_attendedSuccessfully = new System.Windows.Forms.Label();
            this.attendence_servedName_label = new System.Windows.Forms.Label();
            this.attendence_idNumber_label = new System.Windows.Forms.Label();
            this.attendence_main_label = new System.Windows.Forms.Label();
            this.attendence_search_button = new System.Windows.Forms.Button();
            this.attendence_search_label = new System.Windows.Forms.Label();
            this.attendence_search_textBox = new System.Windows.Forms.TextBox();
            this.report_served_panel = new System.Windows.Forms.Panel();
            this.report_served_details_variableDate_label = new System.Windows.Forms.Label();
            this.report_served_details_birthday_label = new System.Windows.Forms.Label();
            this.report_served_details_variableGrade_label = new System.Windows.Forms.Label();
            this.report_served_details_grade_label = new System.Windows.Forms.Label();
            this.report_served_details_variableFather_label = new System.Windows.Forms.Label();
            this.report_served_details_father_label = new System.Windows.Forms.Label();
            this.report_served_details_variablePhone_label = new System.Windows.Forms.Label();
            this.report_served_details_phone_label = new System.Windows.Forms.Label();
            this.report_served_details_variableName_label = new System.Windows.Forms.Label();
            this.report_served_details_variableId_label = new System.Windows.Forms.Label();
            this.report_served_details_main_label = new System.Windows.Forms.Label();
            this.report_served_details_name_label = new System.Windows.Forms.Label();
            this.report_served_details_id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.report_served_main_label = new System.Windows.Forms.Label();
            this.report_served_showResult_button = new System.Windows.Forms.Button();
            this.report_served_showResult_label = new System.Windows.Forms.Label();
            this.report_served_showResult_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attendence_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_main_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutServed_button = new System.Windows.Forms.ToolStripMenuItem();
            this.report_period_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutWeek_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutMonth_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutThreeMonths_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutSixMonths_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutYear_button = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewServed_button = new System.Windows.Forms.ToolStripMenuItem();
            this.attendence_panel.SuspendLayout();
            this.attendence_attended_panel.SuspendLayout();
            this.report_served_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendence_panel
            // 
            this.attendence_panel.Controls.Add(this.attendence_todayIsMeeting_button);
            this.attendence_panel.Controls.Add(this.attendence_noMeeting_label);
            this.attendence_panel.Controls.Add(this.attendence_attended_panel);
            this.attendence_panel.Controls.Add(this.attendence_main_label);
            this.attendence_panel.Controls.Add(this.attendence_search_button);
            this.attendence_panel.Controls.Add(this.attendence_search_label);
            this.attendence_panel.Controls.Add(this.attendence_search_textBox);
            this.attendence_panel.Location = new System.Drawing.Point(0, 88);
            this.attendence_panel.Name = "attendence_panel";
            this.attendence_panel.Size = new System.Drawing.Size(1128, 580);
            this.attendence_panel.TabIndex = 3;
            this.attendence_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.attendence_panel_Paint);
            // 
            // attendence_todayIsMeeting_button
            // 
            this.attendence_todayIsMeeting_button.Font = new System.Drawing.Font("Tahoma", 15F);
            this.attendence_todayIsMeeting_button.Location = new System.Drawing.Point(478, 479);
            this.attendence_todayIsMeeting_button.Name = "attendence_todayIsMeeting_button";
            this.attendence_todayIsMeeting_button.Size = new System.Drawing.Size(233, 58);
            this.attendence_todayIsMeeting_button.TabIndex = 6;
            this.attendence_todayIsMeeting_button.Text = "اليوم هو اجتماع";
            this.attendence_todayIsMeeting_button.UseVisualStyleBackColor = true;
            this.attendence_todayIsMeeting_button.Visible = false;
            this.attendence_todayIsMeeting_button.Click += new System.EventHandler(this.attendence_todayIsMeeting_button_Click);
            // 
            // attendence_noMeeting_label
            // 
            this.attendence_noMeeting_label.AutoSize = true;
            this.attendence_noMeeting_label.Font = new System.Drawing.Font("Tahoma", 20F);
            this.attendence_noMeeting_label.Location = new System.Drawing.Point(437, 426);
            this.attendence_noMeeting_label.Name = "attendence_noMeeting_label";
            this.attendence_noMeeting_label.Size = new System.Drawing.Size(297, 41);
            this.attendence_noMeeting_label.TabIndex = 5;
            this.attendence_noMeeting_label.Text = "اليوم لا يوجد اجتماع";
            this.attendence_noMeeting_label.Visible = false;
            // 
            // attendence_attended_panel
            // 
            this.attendence_attended_panel.Controls.Add(this.attendence_cancelAttendence_button);
            this.attendence_attended_panel.Controls.Add(this.attendence_variable_name_label);
            this.attendence_attended_panel.Controls.Add(this.attendence_id_variable_label);
            this.attendence_attended_panel.Controls.Add(this.attendence_label_attendedSuccessfully);
            this.attendence_attended_panel.Controls.Add(this.attendence_servedName_label);
            this.attendence_attended_panel.Controls.Add(this.attendence_idNumber_label);
            this.attendence_attended_panel.Location = new System.Drawing.Point(20, 81);
            this.attendence_attended_panel.Name = "attendence_attended_panel";
            this.attendence_attended_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.attendence_attended_panel.Size = new System.Drawing.Size(524, 459);
            this.attendence_attended_panel.TabIndex = 3;
            this.attendence_attended_panel.Visible = false;
            this.attendence_attended_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.attendence_panel_correct_Paint);
            // 
            // attendence_cancelAttendence_button
            // 
            this.attendence_cancelAttendence_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.attendence_cancelAttendence_button.Location = new System.Drawing.Point(298, 378);
            this.attendence_cancelAttendence_button.Name = "attendence_cancelAttendence_button";
            this.attendence_cancelAttendence_button.Size = new System.Drawing.Size(119, 38);
            this.attendence_cancelAttendence_button.TabIndex = 7;
            this.attendence_cancelAttendence_button.Text = "الغاء حضور";
            this.attendence_cancelAttendence_button.UseVisualStyleBackColor = true;
            this.attendence_cancelAttendence_button.Click += new System.EventHandler(this.attendence_cancelAttendence_button_Click);
            // 
            // attendence_variable_name_label
            // 
            this.attendence_variable_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attendence_variable_name_label.AutoSize = true;
            this.attendence_variable_name_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_variable_name_label.Location = new System.Drawing.Point(125, 165);
            this.attendence_variable_name_label.Name = "attendence_variable_name_label";
            this.attendence_variable_name_label.Size = new System.Drawing.Size(224, 35);
            this.attendence_variable_name_label.TabIndex = 6;
            this.attendence_variable_name_label.Text = "جورج صبحى عزيز";
            this.attendence_variable_name_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // attendence_id_variable_label
            // 
            this.attendence_id_variable_label.AutoSize = true;
            this.attendence_id_variable_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_id_variable_label.Location = new System.Drawing.Point(228, 251);
            this.attendence_id_variable_label.Name = "attendence_id_variable_label";
            this.attendence_id_variable_label.Size = new System.Drawing.Size(47, 35);
            this.attendence_id_variable_label.TabIndex = 5;
            this.attendence_id_variable_label.Text = "56";
            // 
            // attendence_label_attendedSuccessfully
            // 
            this.attendence_label_attendedSuccessfully.AutoSize = true;
            this.attendence_label_attendedSuccessfully.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_label_attendedSuccessfully.Location = new System.Drawing.Point(211, 57);
            this.attendence_label_attendedSuccessfully.Name = "attendence_label_attendedSuccessfully";
            this.attendence_label_attendedSuccessfully.Size = new System.Drawing.Size(232, 35);
            this.attendence_label_attendedSuccessfully.TabIndex = 0;
            this.attendence_label_attendedSuccessfully.Text = "تم تسجيل الحضور";
            // 
            // attendence_servedName_label
            // 
            this.attendence_servedName_label.AutoSize = true;
            this.attendence_servedName_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_servedName_label.Location = new System.Drawing.Point(355, 165);
            this.attendence_servedName_label.Name = "attendence_servedName_label";
            this.attendence_servedName_label.Size = new System.Drawing.Size(88, 35);
            this.attendence_servedName_label.TabIndex = 4;
            this.attendence_servedName_label.Text = "الاسم";
            // 
            // attendence_idNumber_label
            // 
            this.attendence_idNumber_label.AutoSize = true;
            this.attendence_idNumber_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_idNumber_label.Location = new System.Drawing.Point(289, 251);
            this.attendence_idNumber_label.Name = "attendence_idNumber_label";
            this.attendence_idNumber_label.Size = new System.Drawing.Size(154, 35);
            this.attendence_idNumber_label.TabIndex = 3;
            this.attendence_idNumber_label.Text = "رقم الكشف";
            // 
            // attendence_main_label
            // 
            this.attendence_main_label.AutoSize = true;
            this.attendence_main_label.Font = new System.Drawing.Font("Tahoma", 27F);
            this.attendence_main_label.Location = new System.Drawing.Point(484, 8);
            this.attendence_main_label.Name = "attendence_main_label";
            this.attendence_main_label.Size = new System.Drawing.Size(149, 54);
            this.attendence_main_label.TabIndex = 2;
            this.attendence_main_label.Text = "الحضور";
            // 
            // attendence_search_button
            // 
            this.attendence_search_button.Font = new System.Drawing.Font("Tahoma", 15F);
            this.attendence_search_button.Location = new System.Drawing.Point(787, 301);
            this.attendence_search_button.Name = "attendence_search_button";
            this.attendence_search_button.Size = new System.Drawing.Size(256, 58);
            this.attendence_search_button.TabIndex = 4;
            this.attendence_search_button.Text = "حضور";
            this.attendence_search_button.UseVisualStyleBackColor = true;
            this.attendence_search_button.Click += new System.EventHandler(this.attendence_search_button_Click);
            // 
            // attendence_search_label
            // 
            this.attendence_search_label.AutoSize = true;
            this.attendence_search_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.attendence_search_label.Location = new System.Drawing.Point(711, 148);
            this.attendence_search_label.Name = "attendence_search_label";
            this.attendence_search_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.attendence_search_label.Size = new System.Drawing.Size(338, 35);
            this.attendence_search_label.TabIndex = 1;
            this.attendence_search_label.Text = "بحث بالاسم او رقم الكشف";
            // 
            // attendence_search_textBox
            // 
            this.attendence_search_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.attendence_search_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.attendence_search_textBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendence_search_textBox.Location = new System.Drawing.Point(655, 220);
            this.attendence_search_textBox.Name = "attendence_search_textBox";
            this.attendence_search_textBox.Size = new System.Drawing.Size(388, 35);
            this.attendence_search_textBox.TabIndex = 0;
            this.attendence_search_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attendence_search_textBox.TextChanged += new System.EventHandler(this.attendence_search_textBox_TextChanged);
            // 
            // report_served_panel
            // 
            this.report_served_panel.AutoScroll = true;
            this.report_served_panel.Controls.Add(this.report_served_details_variableDate_label);
            this.report_served_panel.Controls.Add(this.report_served_details_birthday_label);
            this.report_served_panel.Controls.Add(this.report_served_details_variableGrade_label);
            this.report_served_panel.Controls.Add(this.report_served_details_grade_label);
            this.report_served_panel.Controls.Add(this.report_served_details_variableFather_label);
            this.report_served_panel.Controls.Add(this.report_served_details_father_label);
            this.report_served_panel.Controls.Add(this.report_served_details_variablePhone_label);
            this.report_served_panel.Controls.Add(this.report_served_details_phone_label);
            this.report_served_panel.Controls.Add(this.report_served_details_variableName_label);
            this.report_served_panel.Controls.Add(this.report_served_details_variableId_label);
            this.report_served_panel.Controls.Add(this.report_served_details_main_label);
            this.report_served_panel.Controls.Add(this.report_served_details_name_label);
            this.report_served_panel.Controls.Add(this.report_served_details_id_label);
            this.report_served_panel.Controls.Add(this.label1);
            this.report_served_panel.Controls.Add(this.report_served_main_label);
            this.report_served_panel.Controls.Add(this.report_served_showResult_button);
            this.report_served_panel.Controls.Add(this.report_served_showResult_label);
            this.report_served_panel.Controls.Add(this.report_served_showResult_textBox);
            this.report_served_panel.Location = new System.Drawing.Point(3, 61);
            this.report_served_panel.Name = "report_served_panel";
            this.report_served_panel.Size = new System.Drawing.Size(1119, 626);
            this.report_served_panel.TabIndex = 5;
            this.report_served_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.report_served_panel_Paint);
            // 
            // report_served_details_variableDate_label
            // 
            this.report_served_details_variableDate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_served_details_variableDate_label.AutoSize = true;
            this.report_served_details_variableDate_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variableDate_label.Location = new System.Drawing.Point(105, 682);
            this.report_served_details_variableDate_label.Name = "report_served_details_variableDate_label";
            this.report_served_details_variableDate_label.Size = new System.Drawing.Size(165, 35);
            this.report_served_details_variableDate_label.TabIndex = 26;
            this.report_served_details_variableDate_label.Text = "30/08/2001";
            this.report_served_details_variableDate_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_details_birthday_label
            // 
            this.report_served_details_birthday_label.AutoSize = true;
            this.report_served_details_birthday_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_birthday_label.Location = new System.Drawing.Point(363, 680);
            this.report_served_details_birthday_label.Name = "report_served_details_birthday_label";
            this.report_served_details_birthday_label.Size = new System.Drawing.Size(158, 35);
            this.report_served_details_birthday_label.TabIndex = 25;
            this.report_served_details_birthday_label.Text = "تاريخ الميلاد";
            // 
            // report_served_details_variableGrade_label
            // 
            this.report_served_details_variableGrade_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_served_details_variableGrade_label.AutoSize = true;
            this.report_served_details_variableGrade_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variableGrade_label.Location = new System.Drawing.Point(727, 680);
            this.report_served_details_variableGrade_label.Name = "report_served_details_variableGrade_label";
            this.report_served_details_variableGrade_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.report_served_details_variableGrade_label.Size = new System.Drawing.Size(71, 35);
            this.report_served_details_variableGrade_label.TabIndex = 24;
            this.report_served_details_variableGrade_label.Text = "الاول";
            this.report_served_details_variableGrade_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_details_grade_label
            // 
            this.report_served_details_grade_label.AutoSize = true;
            this.report_served_details_grade_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_grade_label.Location = new System.Drawing.Point(843, 682);
            this.report_served_details_grade_label.Name = "report_served_details_grade_label";
            this.report_served_details_grade_label.Size = new System.Drawing.Size(193, 35);
            this.report_served_details_grade_label.TabIndex = 23;
            this.report_served_details_grade_label.Text = "الصف الدراسى";
            // 
            // report_served_details_variableFather_label
            // 
            this.report_served_details_variableFather_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_served_details_variableFather_label.AutoSize = true;
            this.report_served_details_variableFather_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variableFather_label.Location = new System.Drawing.Point(139, 595);
            this.report_served_details_variableFather_label.Name = "report_served_details_variableFather_label";
            this.report_served_details_variableFather_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.report_served_details_variableFather_label.Size = new System.Drawing.Size(137, 35);
            this.report_served_details_variableFather_label.TabIndex = 22;
            this.report_served_details_variableFather_label.Text = "ابونا بافلى";
            this.report_served_details_variableFather_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_details_father_label
            // 
            this.report_served_details_father_label.AutoSize = true;
            this.report_served_details_father_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_father_label.Location = new System.Drawing.Point(363, 591);
            this.report_served_details_father_label.Name = "report_served_details_father_label";
            this.report_served_details_father_label.Size = new System.Drawing.Size(150, 35);
            this.report_served_details_father_label.TabIndex = 21;
            this.report_served_details_father_label.Text = "اب الاعتراف";
            // 
            // report_served_details_variablePhone_label
            // 
            this.report_served_details_variablePhone_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_served_details_variablePhone_label.AutoSize = true;
            this.report_served_details_variablePhone_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variablePhone_label.Location = new System.Drawing.Point(614, 596);
            this.report_served_details_variablePhone_label.Name = "report_served_details_variablePhone_label";
            this.report_served_details_variablePhone_label.Size = new System.Drawing.Size(191, 35);
            this.report_served_details_variablePhone_label.TabIndex = 20;
            this.report_served_details_variablePhone_label.Text = "01025727885";
            this.report_served_details_variablePhone_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_details_phone_label
            // 
            this.report_served_details_phone_label.AutoSize = true;
            this.report_served_details_phone_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_phone_label.Location = new System.Drawing.Point(877, 595);
            this.report_served_details_phone_label.Name = "report_served_details_phone_label";
            this.report_served_details_phone_label.Size = new System.Drawing.Size(159, 35);
            this.report_served_details_phone_label.TabIndex = 19;
            this.report_served_details_phone_label.Text = "رقم التليفون";
            // 
            // report_served_details_variableName_label
            // 
            this.report_served_details_variableName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report_served_details_variableName_label.AutoSize = true;
            this.report_served_details_variableName_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variableName_label.Location = new System.Drawing.Point(600, 497);
            this.report_served_details_variableName_label.Name = "report_served_details_variableName_label";
            this.report_served_details_variableName_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.report_served_details_variableName_label.Size = new System.Drawing.Size(224, 35);
            this.report_served_details_variableName_label.TabIndex = 18;
            this.report_served_details_variableName_label.Text = "جورج صبحى عزيز";
            this.report_served_details_variableName_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_details_variableId_label
            // 
            this.report_served_details_variableId_label.AutoSize = true;
            this.report_served_details_variableId_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_variableId_label.Location = new System.Drawing.Point(196, 492);
            this.report_served_details_variableId_label.Name = "report_served_details_variableId_label";
            this.report_served_details_variableId_label.Size = new System.Drawing.Size(47, 35);
            this.report_served_details_variableId_label.TabIndex = 17;
            this.report_served_details_variableId_label.Text = "56";
            // 
            // report_served_details_main_label
            // 
            this.report_served_details_main_label.AutoSize = true;
            this.report_served_details_main_label.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_served_details_main_label.Location = new System.Drawing.Point(431, 382);
            this.report_served_details_main_label.Name = "report_served_details_main_label";
            this.report_served_details_main_label.Size = new System.Drawing.Size(241, 40);
            this.report_served_details_main_label.TabIndex = 14;
            this.report_served_details_main_label.Text = "بيانات المخدوم";
            // 
            // report_served_details_name_label
            // 
            this.report_served_details_name_label.AutoSize = true;
            this.report_served_details_name_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_name_label.Location = new System.Drawing.Point(948, 492);
            this.report_served_details_name_label.Name = "report_served_details_name_label";
            this.report_served_details_name_label.Size = new System.Drawing.Size(88, 35);
            this.report_served_details_name_label.TabIndex = 16;
            this.report_served_details_name_label.Text = "الاسم";
            // 
            // report_served_details_id_label
            // 
            this.report_served_details_id_label.AutoSize = true;
            this.report_served_details_id_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_details_id_label.Location = new System.Drawing.Point(359, 492);
            this.report_served_details_id_label.Name = "report_served_details_id_label";
            this.report_served_details_id_label.Size = new System.Drawing.Size(154, 35);
            this.report_served_details_id_label.TabIndex = 15;
            this.report_served_details_id_label.Text = "رقم الكشف";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label1.Location = new System.Drawing.Point(1389, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "جورج صبحى عزيز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // report_served_main_label
            // 
            this.report_served_main_label.AutoSize = true;
            this.report_served_main_label.Font = new System.Drawing.Font("Tahoma", 27F);
            this.report_served_main_label.Location = new System.Drawing.Point(410, 25);
            this.report_served_main_label.Name = "report_served_main_label";
            this.report_served_main_label.Size = new System.Drawing.Size(324, 54);
            this.report_served_main_label.TabIndex = 8;
            this.report_served_main_label.Text = "تقرير عن مخدوم";
            // 
            // report_served_showResult_button
            // 
            this.report_served_showResult_button.Font = new System.Drawing.Font("Tahoma", 15F);
            this.report_served_showResult_button.Location = new System.Drawing.Point(773, 291);
            this.report_served_showResult_button.Name = "report_served_showResult_button";
            this.report_served_showResult_button.Size = new System.Drawing.Size(256, 58);
            this.report_served_showResult_button.TabIndex = 7;
            this.report_served_showResult_button.Text = "اظهار نتائج";
            this.report_served_showResult_button.UseVisualStyleBackColor = true;
            // 
            // report_served_showResult_label
            // 
            this.report_served_showResult_label.AutoSize = true;
            this.report_served_showResult_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.report_served_showResult_label.Location = new System.Drawing.Point(697, 138);
            this.report_served_showResult_label.Name = "report_served_showResult_label";
            this.report_served_showResult_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.report_served_showResult_label.Size = new System.Drawing.Size(338, 35);
            this.report_served_showResult_label.TabIndex = 6;
            this.report_served_showResult_label.Text = "بحث بالاسم او رقم الكشف";
            // 
            // report_served_showResult_textBox
            // 
            this.report_served_showResult_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.report_served_showResult_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.report_served_showResult_textBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_served_showResult_textBox.Location = new System.Drawing.Point(641, 210);
            this.report_served_showResult_textBox.Name = "report_served_showResult_textBox";
            this.report_served_showResult_textBox.Size = new System.Drawing.Size(388, 35);
            this.report_served_showResult_textBox.TabIndex = 5;
            this.report_served_showResult_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendence_button,
            this.reports_main_button,
            this.addNewServed_button});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 53);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "program_mainMenu_menustrip";
            // 
            // attendence_button
            // 
            this.attendence_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.attendence_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.attendence_button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.attendence_button.Name = "attendence_button";
            this.attendence_button.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.attendence_button.Size = new System.Drawing.Size(126, 49);
            this.attendence_button.Text = "الحضور";
            // 
            // reports_main_button
            // 
            this.reports_main_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.reports_main_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAboutServed_button,
            this.report_period_button,
            this.reportAboutWeek_button,
            this.reportAboutMonth_button,
            this.reportAboutThreeMonths_button,
            this.reportAboutSixMonths_button,
            this.reportAboutYear_button});
            this.reports_main_button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.reports_main_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.reports_main_button.Name = "reports_main_button";
            this.reports_main_button.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.reports_main_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reports_main_button.Size = new System.Drawing.Size(106, 49);
            this.reports_main_button.Text = "تقارير";
            // 
            // reportAboutServed_button
            // 
            this.reportAboutServed_button.Name = "reportAboutServed_button";
            this.reportAboutServed_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutServed_button.Text = "تقرير عن مخدوم";
            // 
            // report_period_button
            // 
            this.report_period_button.Name = "report_period_button";
            this.report_period_button.Size = new System.Drawing.Size(300, 40);
            this.report_period_button.Text = "تقرير عن مدة معينة";
            // 
            // reportAboutWeek_button
            // 
            this.reportAboutWeek_button.Name = "reportAboutWeek_button";
            this.reportAboutWeek_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutWeek_button.Text = "تقرير عن اسبوع";
            // 
            // reportAboutMonth_button
            // 
            this.reportAboutMonth_button.Name = "reportAboutMonth_button";
            this.reportAboutMonth_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutMonth_button.Text = "تقرير عن شهر";
            // 
            // reportAboutThreeMonths_button
            // 
            this.reportAboutThreeMonths_button.Name = "reportAboutThreeMonths_button";
            this.reportAboutThreeMonths_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutThreeMonths_button.Text = "تقرير عن 3 اشهر";
            // 
            // reportAboutSixMonths_button
            // 
            this.reportAboutSixMonths_button.Name = "reportAboutSixMonths_button";
            this.reportAboutSixMonths_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutSixMonths_button.Text = "تقرير عن 6 اشهر";
            // 
            // reportAboutYear_button
            // 
            this.reportAboutYear_button.Name = "reportAboutYear_button";
            this.reportAboutYear_button.Size = new System.Drawing.Size(300, 40);
            this.reportAboutYear_button.Text = "تقرير عن سنة";
            // 
            // addNewServed_button
            // 
            this.addNewServed_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addNewServed_button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addNewServed_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addNewServed_button.Name = "addNewServed_button";
            this.addNewServed_button.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.addNewServed_button.Size = new System.Drawing.Size(312, 49);
            this.addNewServed_button.Text = "اضافة بيانات مخدوم جديد";
            // 
            // karma_main_form
            // 
            this.AcceptButton = this.attendence_search_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 699);
            this.Controls.Add(this.report_served_panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.attendence_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "karma_main_form";
            this.ShowIcon = false;
            this.Text = "اجتماع اغصان الكرمة";
            this.Load += new System.EventHandler(this.karma_main_form_Load);
            this.attendence_panel.ResumeLayout(false);
            this.attendence_panel.PerformLayout();
            this.attendence_attended_panel.ResumeLayout(false);
            this.attendence_attended_panel.PerformLayout();
            this.report_served_panel.ResumeLayout(false);
            this.report_served_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel attendence_panel;
        private System.Windows.Forms.Panel attendence_attended_panel;
        private System.Windows.Forms.Label attendence_variable_name_label;
        private System.Windows.Forms.Label attendence_id_variable_label;
        private System.Windows.Forms.Label attendence_label_attendedSuccessfully;
        private System.Windows.Forms.Label attendence_servedName_label;
        private System.Windows.Forms.Label attendence_idNumber_label;
        private System.Windows.Forms.Label attendence_main_label;
        private System.Windows.Forms.Button attendence_search_button;
        private System.Windows.Forms.Label attendence_search_label;
        private System.Windows.Forms.TextBox attendence_search_textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attendence_button;
        private System.Windows.Forms.ToolStripMenuItem reports_main_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutServed_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutWeek_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutMonth_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutThreeMonths_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutSixMonths_button;
        private System.Windows.Forms.ToolStripMenuItem reportAboutYear_button;
        private System.Windows.Forms.ToolStripMenuItem addNewServed_button;
        private System.Windows.Forms.Label attendence_noMeeting_label;
        private System.Windows.Forms.Button attendence_todayIsMeeting_button;
        private System.Windows.Forms.Button attendence_cancelAttendence_button;
        private System.Windows.Forms.Panel report_served_panel;
        private System.Windows.Forms.Label report_served_main_label;
        private System.Windows.Forms.Button report_served_showResult_button;
        private System.Windows.Forms.Label report_served_showResult_label;
        private System.Windows.Forms.TextBox report_served_showResult_textBox;
        private System.Windows.Forms.ToolStripMenuItem report_period_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label report_served_details_variableName_label;
        private System.Windows.Forms.Label report_served_details_variableId_label;
        private System.Windows.Forms.Label report_served_details_main_label;
        private System.Windows.Forms.Label report_served_details_name_label;
        private System.Windows.Forms.Label report_served_details_id_label;
        private System.Windows.Forms.Label report_served_details_variableDate_label;
        private System.Windows.Forms.Label report_served_details_birthday_label;
        private System.Windows.Forms.Label report_served_details_variableGrade_label;
        private System.Windows.Forms.Label report_served_details_grade_label;
        private System.Windows.Forms.Label report_served_details_variableFather_label;
        private System.Windows.Forms.Label report_served_details_father_label;
        private System.Windows.Forms.Label report_served_details_variablePhone_label;
        private System.Windows.Forms.Label report_served_details_phone_label;
    }
}

