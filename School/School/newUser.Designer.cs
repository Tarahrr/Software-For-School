namespace School
{
    partial class newUser
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
            this.components = new System.ComponentModel.Container();
            this.titleLB = new System.Windows.Forms.Label();
            this.TeacherRBTN = new System.Windows.Forms.RadioButton();
            this.studentRBTN = new System.Windows.Forms.RadioButton();
            this.jobLB = new System.Windows.Forms.Label();
            this.registerBTN = new System.Windows.Forms.Button();
            this.passTB2 = new System.Windows.Forms.TextBox();
            this.repeatpassLB = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passLB = new System.Windows.Forms.Label();
            this.usernameLB = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new School.DataSet1TableAdapters.UsersTableAdapter();
            this.dataSet1 = new School.DataSet1();
            this.studentTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTBLTableAdapter = new School.DataSet1TableAdapters.StudentTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleLB.Location = new System.Drawing.Point(144, 27);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(84, 24);
            this.titleLB.TabIndex = 28;
            this.titleLB.Text = "کاربر جدید";
            // 
            // TeacherRBTN
            // 
            this.TeacherRBTN.AutoSize = true;
            this.TeacherRBTN.Location = new System.Drawing.Point(77, 225);
            this.TeacherRBTN.Name = "TeacherRBTN";
            this.TeacherRBTN.Size = new System.Drawing.Size(43, 17);
            this.TeacherRBTN.TabIndex = 27;
            this.TeacherRBTN.TabStop = true;
            this.TeacherRBTN.Text = "دبیر";
            this.TeacherRBTN.UseVisualStyleBackColor = true;
            // 
            // studentRBTN
            // 
            this.studentRBTN.AutoSize = true;
            this.studentRBTN.Location = new System.Drawing.Point(159, 225);
            this.studentRBTN.Name = "studentRBTN";
            this.studentRBTN.Size = new System.Drawing.Size(69, 17);
            this.studentRBTN.TabIndex = 26;
            this.studentRBTN.TabStop = true;
            this.studentRBTN.Text = "دانش آموز";
            this.studentRBTN.UseVisualStyleBackColor = true;
            // 
            // jobLB
            // 
            this.jobLB.AutoSize = true;
            this.jobLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.jobLB.Location = new System.Drawing.Point(252, 223);
            this.jobLB.Name = "jobLB";
            this.jobLB.Size = new System.Drawing.Size(46, 19);
            this.jobLB.TabIndex = 25;
            this.jobLB.Text = ": سمت";
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.registerBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.registerBTN.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.registerBTN.ForeColor = System.Drawing.Color.White;
            this.registerBTN.Location = new System.Drawing.Point(118, 275);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(110, 33);
            this.registerBTN.TabIndex = 23;
            this.registerBTN.Text = "ثبت";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // passTB2
            // 
            this.passTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passTB2.Location = new System.Drawing.Point(77, 176);
            this.passTB2.Name = "passTB2";
            this.passTB2.PasswordChar = '*';
            this.passTB2.Size = new System.Drawing.Size(151, 26);
            this.passTB2.TabIndex = 22;
            // 
            // repeatpassLB
            // 
            this.repeatpassLB.AutoSize = true;
            this.repeatpassLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.repeatpassLB.Location = new System.Drawing.Point(252, 176);
            this.repeatpassLB.Name = "repeatpassLB";
            this.repeatpassLB.Size = new System.Drawing.Size(99, 19);
            this.repeatpassLB.TabIndex = 21;
            this.repeatpassLB.Text = ": تکرار گذر واژه";
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passTB.Location = new System.Drawing.Point(77, 125);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(151, 26);
            this.passTB.TabIndex = 20;
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernameTB.Location = new System.Drawing.Point(77, 78);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(151, 26);
            this.usernameTB.TabIndex = 19;
            // 
            // passLB
            // 
            this.passLB.AutoSize = true;
            this.passLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passLB.Location = new System.Drawing.Point(252, 129);
            this.passLB.Name = "passLB";
            this.passLB.Size = new System.Drawing.Size(60, 19);
            this.passLB.TabIndex = 18;
            this.passLB.Text = ": گذرواژه";
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernameLB.Location = new System.Drawing.Point(252, 82);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(75, 19);
            this.usernameLB.TabIndex = 17;
            this.usernameLB.Text = ": نام کاربری";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTBLBindingSource
            // 
            this.studentTBLBindingSource.DataMember = "StudentTBL";
            this.studentTBLBindingSource.DataSource = this.dataSet1;
            // 
            // studentTBLTableAdapter
            // 
            this.studentTBLTableAdapter.ClearBeforeFill = true;
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 335);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.TeacherRBTN);
            this.Controls.Add(this.studentRBTN);
            this.Controls.Add(this.jobLB);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.passTB2);
            this.Controls.Add(this.repeatpassLB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passLB);
            this.Controls.Add(this.usernameLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "newUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربر جدید";
            this.Load += new System.EventHandler(this.newUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.RadioButton TeacherRBTN;
        private System.Windows.Forms.RadioButton studentRBTN;
        private System.Windows.Forms.Label jobLB;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.TextBox passTB2;
        private System.Windows.Forms.Label repeatpassLB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label passLB;
        private System.Windows.Forms.Label usernameLB;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentTBLBindingSource;
        private DataSet1TableAdapters.StudentTBLTableAdapter studentTBLTableAdapter;
    }
}