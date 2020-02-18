namespace Test
{
    partial class EditStudent
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
            this.gbStudentData = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbUndergrad = new System.Windows.Forms.RadioButton();
            this.rbPostgrad = new System.Windows.Forms.RadioButton();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCourseReadOnly = new System.Windows.Forms.Label();
            this.lblSurnameReadOnly = new System.Windows.Forms.Label();
            this.lblFirstNameReadOnly = new System.Windows.Forms.Label();
            this.lblStudentIdReadOnly = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.gbStudentSearch = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentIdSearch = new System.Windows.Forms.TextBox();
            this.lblStudentIdSearch = new System.Windows.Forms.Label();
            this.gbStudentData.SuspendLayout();
            this.gbStudentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStudentData
            // 
            this.gbStudentData.Controls.Add(this.btnUpdate);
            this.gbStudentData.Controls.Add(this.rbUndergrad);
            this.gbStudentData.Controls.Add(this.rbPostgrad);
            this.gbStudentData.Controls.Add(this.cbCounty);
            this.gbStudentData.Controls.Add(this.txtCity);
            this.gbStudentData.Controls.Add(this.txtAddress2);
            this.gbStudentData.Controls.Add(this.txtAddress1);
            this.gbStudentData.Controls.Add(this.txtPhone);
            this.gbStudentData.Controls.Add(this.txtEmail);
            this.gbStudentData.Controls.Add(this.lblCourseReadOnly);
            this.gbStudentData.Controls.Add(this.lblSurnameReadOnly);
            this.gbStudentData.Controls.Add(this.lblFirstNameReadOnly);
            this.gbStudentData.Controls.Add(this.lblStudentIdReadOnly);
            this.gbStudentData.Controls.Add(this.lblCourse);
            this.gbStudentData.Controls.Add(this.lblLevel);
            this.gbStudentData.Controls.Add(this.lblCounty);
            this.gbStudentData.Controls.Add(this.lblCity);
            this.gbStudentData.Controls.Add(this.lblAddress2);
            this.gbStudentData.Controls.Add(this.lblAdress1);
            this.gbStudentData.Controls.Add(this.lblPhone);
            this.gbStudentData.Controls.Add(this.lblEmail);
            this.gbStudentData.Controls.Add(this.lblSurname);
            this.gbStudentData.Controls.Add(this.lblFirstName);
            this.gbStudentData.Controls.Add(this.lblStudentId);
            this.gbStudentData.Location = new System.Drawing.Point(74, 177);
            this.gbStudentData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentData.Name = "gbStudentData";
            this.gbStudentData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentData.Size = new System.Drawing.Size(651, 610);
            this.gbStudentData.TabIndex = 3;
            this.gbStudentData.TabStop = false;
            this.gbStudentData.Text = "Student Data";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(506, 550);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbUndergrad
            // 
            this.rbUndergrad.AutoSize = true;
            this.rbUndergrad.Location = new System.Drawing.Point(492, 448);
            this.rbUndergrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUndergrad.Name = "rbUndergrad";
            this.rbUndergrad.Size = new System.Drawing.Size(142, 24);
            this.rbUndergrad.TabIndex = 22;
            this.rbUndergrad.TabStop = true;
            this.rbUndergrad.Text = "Undergraduate";
            this.rbUndergrad.UseVisualStyleBackColor = true;
            // 
            // rbPostgrad
            // 
            this.rbPostgrad.AutoSize = true;
            this.rbPostgrad.Location = new System.Drawing.Point(354, 448);
            this.rbPostgrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPostgrad.Name = "rbPostgrad";
            this.rbPostgrad.Size = new System.Drawing.Size(130, 24);
            this.rbPostgrad.TabIndex = 21;
            this.rbPostgrad.TabStop = true;
            this.rbPostgrad.Text = "Postgraduate";
            this.rbPostgrad.UseVisualStyleBackColor = true;
            // 
            // cbCounty
            // 
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbCounty.Location = new System.Drawing.Point(354, 402);
            this.cbCounty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(240, 28);
            this.cbCounty.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(354, 360);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(240, 26);
            this.txtCity.TabIndex = 19;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(354, 312);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(240, 26);
            this.txtAddress2.TabIndex = 18;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(354, 271);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(240, 26);
            this.txtAddress1.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(354, 226);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 26);
            this.txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(354, 182);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // lblCourseReadOnly
            // 
            this.lblCourseReadOnly.AutoSize = true;
            this.lblCourseReadOnly.Location = new System.Drawing.Point(354, 494);
            this.lblCourseReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseReadOnly.Name = "lblCourseReadOnly";
            this.lblCourseReadOnly.Size = new System.Drawing.Size(0, 20);
            this.lblCourseReadOnly.TabIndex = 14;
            // 
            // lblSurnameReadOnly
            // 
            this.lblSurnameReadOnly.AutoSize = true;
            this.lblSurnameReadOnly.Location = new System.Drawing.Point(354, 142);
            this.lblSurnameReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameReadOnly.Name = "lblSurnameReadOnly";
            this.lblSurnameReadOnly.Size = new System.Drawing.Size(0, 20);
            this.lblSurnameReadOnly.TabIndex = 13;
            // 
            // lblFirstNameReadOnly
            // 
            this.lblFirstNameReadOnly.AutoSize = true;
            this.lblFirstNameReadOnly.Location = new System.Drawing.Point(354, 100);
            this.lblFirstNameReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameReadOnly.Name = "lblFirstNameReadOnly";
            this.lblFirstNameReadOnly.Size = new System.Drawing.Size(0, 20);
            this.lblFirstNameReadOnly.TabIndex = 12;
            // 
            // lblStudentIdReadOnly
            // 
            this.lblStudentIdReadOnly.AutoSize = true;
            this.lblStudentIdReadOnly.Location = new System.Drawing.Point(354, 63);
            this.lblStudentIdReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentIdReadOnly.Name = "lblStudentIdReadOnly";
            this.lblStudentIdReadOnly.Size = new System.Drawing.Size(0, 20);
            this.lblStudentIdReadOnly.TabIndex = 11;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(85, 494);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 20);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Course:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(85, 448);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "Level:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(85, 402);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(63, 20);
            this.lblCounty.TabIndex = 8;
            this.lblCounty.Text = "County:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(85, 360);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(85, 312);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(119, 20);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Location = new System.Drawing.Point(85, 271);
            this.lblAdress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(119, 20);
            this.lblAdress1.TabIndex = 5;
            this.lblAdress1.Text = "Address Line 1:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(85, 226);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(85, 182);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(85, 142);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(85, 100);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(85, 63);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(88, 20);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student Id:";
            // 
            // gbStudentSearch
            // 
            this.gbStudentSearch.Controls.Add(this.btnReturn);
            this.gbStudentSearch.Controls.Add(this.btnSearch);
            this.gbStudentSearch.Controls.Add(this.txtStudentIdSearch);
            this.gbStudentSearch.Controls.Add(this.lblStudentIdSearch);
            this.gbStudentSearch.Location = new System.Drawing.Point(74, 37);
            this.gbStudentSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentSearch.Name = "gbStudentSearch";
            this.gbStudentSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStudentSearch.Size = new System.Drawing.Size(651, 109);
            this.gbStudentSearch.TabIndex = 2;
            this.gbStudentSearch.TabStop = false;
            this.gbStudentSearch.Text = "Student Search";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(532, 47);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 37);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(404, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentIdSearch
            // 
            this.txtStudentIdSearch.Location = new System.Drawing.Point(207, 48);
            this.txtStudentIdSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentIdSearch.Name = "txtStudentIdSearch";
            this.txtStudentIdSearch.Size = new System.Drawing.Size(163, 26);
            this.txtStudentIdSearch.TabIndex = 1;
            // 
            // lblStudentIdSearch
            // 
            this.lblStudentIdSearch.AutoSize = true;
            this.lblStudentIdSearch.Location = new System.Drawing.Point(46, 52);
            this.lblStudentIdSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentIdSearch.Name = "lblStudentIdSearch";
            this.lblStudentIdSearch.Size = new System.Drawing.Size(131, 20);
            this.lblStudentIdSearch.TabIndex = 0;
            this.lblStudentIdSearch.Text = "Enter Student Id:";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 821);
            this.Controls.Add(this.gbStudentData);
            this.Controls.Add(this.gbStudentSearch);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditStudent_FormClosed);
            this.gbStudentData.ResumeLayout(false);
            this.gbStudentData.PerformLayout();
            this.gbStudentSearch.ResumeLayout(false);
            this.gbStudentSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbUndergrad;
        private System.Windows.Forms.RadioButton rbPostgrad;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCourseReadOnly;
        private System.Windows.Forms.Label lblSurnameReadOnly;
        private System.Windows.Forms.Label lblFirstNameReadOnly;
        private System.Windows.Forms.Label lblStudentIdReadOnly;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.GroupBox gbStudentSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentIdSearch;
        private System.Windows.Forms.Label lblStudentIdSearch;
    }
}