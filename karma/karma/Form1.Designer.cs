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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attendence_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_main_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutServed_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutWeek_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutMonth_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutThreeMonths_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutSixMonths_button = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutYear_button = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewServed_button = new System.Windows.Forms.ToolStripMenuItem();
            this.add_panel = new System.Windows.Forms.Panel();
            this.add_main_label = new System.Windows.Forms.Label();
            this.add_newServed_button = new System.Windows.Forms.Button();
            this.add_name_label = new System.Windows.Forms.Label();
            this.add_name_textBox = new System.Windows.Forms.TextBox();
            this.add_grade_comboBox = new System.Windows.Forms.ComboBox();
            this.add_grade_label = new System.Windows.Forms.Label();
            this.add_phone_label = new System.Windows.Forms.Label();
            this.add_phone_textBox = new System.Windows.Forms.TextBox();
            this.add_father_label = new System.Windows.Forms.Label();
            this.add_father_comboBox = new System.Windows.Forms.ComboBox();
            this.add_birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.add_birthday_label = new System.Windows.Forms.Label();
            this.attendence_panel.SuspendLayout();
            this.attendence_attended_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.add_panel.SuspendLayout();
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
            this.attendence_panel.Location = new System.Drawing.Point(3, 126);
            this.attendence_panel.Name = "attendence_panel";
            this.attendence_panel.Size = new System.Drawing.Size(1128, 580);
            this.attendence_panel.TabIndex = 3;
            this.attendence_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.attendence_panel_Paint);
            // 
            // attendence_todayIsMeeting_button
            // 
            this.attendence_todayIsMeeting_button.Font = new System.Drawing.Font("Tahoma", 15F);
            this.attendence_todayIsMeeting_button.Location = new System.Drawing.Point(810, 459);
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
            this.attendence_noMeeting_label.Location = new System.Drawing.Point(746, 398);
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
            this.reportAboutServed_button.Size = new System.Drawing.Size(264, 40);
            this.reportAboutServed_button.Text = "تقرير عن مخدوم";
            // 
            // reportAboutWeek_button
            // 
            this.reportAboutWeek_button.Name = "reportAboutWeek_button";
            this.reportAboutWeek_button.Size = new System.Drawing.Size(264, 40);
            this.reportAboutWeek_button.Text = "تقرير عن اسبوع";
            // 
            // reportAboutMonth_button
            // 
            this.reportAboutMonth_button.Name = "reportAboutMonth_button";
            this.reportAboutMonth_button.Size = new System.Drawing.Size(264, 40);
            this.reportAboutMonth_button.Text = "تقرير عن شهر";
            // 
            // reportAboutThreeMonths_button
            // 
            this.reportAboutThreeMonths_button.Name = "reportAboutThreeMonths_button";
            this.reportAboutThreeMonths_button.Size = new System.Drawing.Size(264, 40);
            this.reportAboutThreeMonths_button.Text = "تقرير عن 3 اشهر";
            // 
            // reportAboutSixMonths_button
            // 
            this.reportAboutSixMonths_button.Name = "reportAboutSixMonths_button";
            this.reportAboutSixMonths_button.Size = new System.Drawing.Size(264, 40);
            this.reportAboutSixMonths_button.Text = "تقرير عن 6 اشهر";
            // 
            // reportAboutYear_button
            // 
            this.reportAboutYear_button.Name = "reportAboutYear_button";
            this.reportAboutYear_button.Size = new System.Drawing.Size(264, 40);
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
            // add_panel
            // 
            this.add_panel.Controls.Add(this.add_birthday_label);
            this.add_panel.Controls.Add(this.add_birthday_dateTimePicker);
            this.add_panel.Controls.Add(this.add_father_label);
            this.add_panel.Controls.Add(this.add_father_comboBox);
            this.add_panel.Controls.Add(this.add_phone_label);
            this.add_panel.Controls.Add(this.add_phone_textBox);
            this.add_panel.Controls.Add(this.add_grade_label);
            this.add_panel.Controls.Add(this.add_grade_comboBox);
            this.add_panel.Controls.Add(this.add_newServed_button);
            this.add_panel.Controls.Add(this.add_name_label);
            this.add_panel.Controls.Add(this.add_name_textBox);
            this.add_panel.Controls.Add(this.add_main_label);
            this.add_panel.Location = new System.Drawing.Point(3, 112);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(1116, 624);
            this.add_panel.TabIndex = 5;
            this.add_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.add_panel_Paint);
            // 
            // add_main_label
            // 
            this.add_main_label.AutoSize = true;
            this.add_main_label.Font = new System.Drawing.Font("Tahoma", 27F);
            this.add_main_label.Location = new System.Drawing.Point(388, 19);
            this.add_main_label.Name = "add_main_label";
            this.add_main_label.Size = new System.Drawing.Size(371, 54);
            this.add_main_label.TabIndex = 3;
            this.add_main_label.Text = "اضافة مخدوم جديد";
            // 
            // add_newServed_button
            // 
            this.add_newServed_button.Font = new System.Drawing.Font("Tahoma", 15F);
            this.add_newServed_button.Location = new System.Drawing.Point(478, 507);
            this.add_newServed_button.Name = "add_newServed_button";
            this.add_newServed_button.Size = new System.Drawing.Size(256, 58);
            this.add_newServed_button.TabIndex = 7;
            this.add_newServed_button.Text = "اضافة";
            this.add_newServed_button.UseVisualStyleBackColor = true;
            // 
            // add_name_label
            // 
            this.add_name_label.AutoSize = true;
            this.add_name_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.add_name_label.Location = new System.Drawing.Point(894, 172);
            this.add_name_label.Name = "add_name_label";
            this.add_name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_name_label.Size = new System.Drawing.Size(177, 35);
            this.add_name_label.TabIndex = 6;
            this.add_name_label.Text = "اسم المخدوم";
            // 
            // add_name_textBox
            // 
            this.add_name_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.add_name_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.add_name_textBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_name_textBox.Location = new System.Drawing.Point(677, 224);
            this.add_name_textBox.Name = "add_name_textBox";
            this.add_name_textBox.Size = new System.Drawing.Size(388, 35);
            this.add_name_textBox.TabIndex = 5;
            this.add_name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add_grade_comboBox
            // 
            this.add_grade_comboBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.add_grade_comboBox.FormattingEnabled = true;
            this.add_grade_comboBox.Items.AddRange(new object[] {
            "الصف الاول",
            "الصف الثانى",
            "الصف الثالث"});
            this.add_grade_comboBox.Location = new System.Drawing.Point(533, 394);
            this.add_grade_comboBox.Name = "add_grade_comboBox";
            this.add_grade_comboBox.Size = new System.Drawing.Size(173, 35);
            this.add_grade_comboBox.TabIndex = 8;
            // 
            // add_grade_label
            // 
            this.add_grade_label.AutoSize = true;
            this.add_grade_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.add_grade_label.Location = new System.Drawing.Point(511, 326);
            this.add_grade_label.Name = "add_grade_label";
            this.add_grade_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_grade_label.Size = new System.Drawing.Size(201, 35);
            this.add_grade_label.TabIndex = 9;
            this.add_grade_label.Text = "السنة الدراسية";
            // 
            // add_phone_label
            // 
            this.add_phone_label.AutoSize = true;
            this.add_phone_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.add_phone_label.Location = new System.Drawing.Point(314, 172);
            this.add_phone_label.Name = "add_phone_label";
            this.add_phone_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_phone_label.Size = new System.Drawing.Size(149, 35);
            this.add_phone_label.TabIndex = 11;
            this.add_phone_label.Text = "رقم التلفون";
            // 
            // add_phone_textBox
            // 
            this.add_phone_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.add_phone_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.add_phone_textBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_phone_textBox.Location = new System.Drawing.Point(69, 224);
            this.add_phone_textBox.Name = "add_phone_textBox";
            this.add_phone_textBox.Size = new System.Drawing.Size(388, 35);
            this.add_phone_textBox.TabIndex = 10;
            this.add_phone_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add_father_label
            // 
            this.add_father_label.AutoSize = true;
            this.add_father_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.add_father_label.Location = new System.Drawing.Point(921, 326);
            this.add_father_label.Name = "add_father_label";
            this.add_father_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_father_label.Size = new System.Drawing.Size(150, 35);
            this.add_father_label.TabIndex = 13;
            this.add_father_label.Text = "اب الاعتراف";
            // 
            // add_father_comboBox
            // 
            this.add_father_comboBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.add_father_comboBox.FormattingEnabled = true;
            this.add_father_comboBox.Items.AddRange(new object[] {
            "ابونا بافلى ",
            "ابونا يوليوس",
            "ابونا موسى ",
            "ابونا اندراوس",
            "ابونا داود",
            "ابونا مرقس",
            "غير ذلك"});
            this.add_father_comboBox.Location = new System.Drawing.Point(892, 394);
            this.add_father_comboBox.Name = "add_father_comboBox";
            this.add_father_comboBox.Size = new System.Drawing.Size(173, 35);
            this.add_father_comboBox.TabIndex = 12;
            // 
            // add_birthday_dateTimePicker
            // 
            this.add_birthday_dateTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 20F);
            this.add_birthday_dateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F);
            this.add_birthday_dateTimePicker.Location = new System.Drawing.Point(23, 397);
            this.add_birthday_dateTimePicker.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.add_birthday_dateTimePicker.Name = "add_birthday_dateTimePicker";
            this.add_birthday_dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_birthday_dateTimePicker.Size = new System.Drawing.Size(349, 32);
            this.add_birthday_dateTimePicker.TabIndex = 14;
            this.add_birthday_dateTimePicker.Value = new System.DateTime(2007, 6, 15, 0, 0, 0, 0);
            // 
            // add_birthday_label
            // 
            this.add_birthday_label.AutoSize = true;
            this.add_birthday_label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.add_birthday_label.Location = new System.Drawing.Point(159, 326);
            this.add_birthday_label.Name = "add_birthday_label";
            this.add_birthday_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_birthday_label.Size = new System.Drawing.Size(219, 35);
            this.add_birthday_label.TabIndex = 15;
            this.add_birthday_label.Text = " تاريخ عيد الميلاد";
            // 
            // karma_main_form
            // 
            this.AcceptButton = this.attendence_search_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 699);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.attendence_panel);
            this.Name = "karma_main_form";
            this.ShowIcon = false;
            this.Text = "اجتماع اغصان الكرمة";
            this.attendence_panel.ResumeLayout(false);
            this.attendence_panel.PerformLayout();
            this.attendence_attended_panel.ResumeLayout(false);
            this.attendence_attended_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
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
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.ComboBox add_grade_comboBox;
        private System.Windows.Forms.Button add_newServed_button;
        private System.Windows.Forms.Label add_name_label;
        private System.Windows.Forms.TextBox add_name_textBox;
        private System.Windows.Forms.Label add_main_label;
        private System.Windows.Forms.Label add_grade_label;
        private System.Windows.Forms.Label add_phone_label;
        private System.Windows.Forms.TextBox add_phone_textBox;
        private System.Windows.Forms.Label add_father_label;
        private System.Windows.Forms.ComboBox add_father_comboBox;
        private System.Windows.Forms.Label add_birthday_label;
        private System.Windows.Forms.DateTimePicker add_birthday_dateTimePicker;
    }
}

