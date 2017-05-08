namespace School
{
    partial class editStudentForm
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.telephoneTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PostCodeTB = new System.Windows.Forms.TextBox();
            this.ClassNoTB = new System.Windows.Forms.TextBox();
            this.BDateTB = new System.Windows.Forms.TextBox();
            this.FatherNameTB = new System.Windows.Forms.TextBox();
            this.ShenasnameTB = new System.Windows.Forms.TextBox();
            this.CodeMeliTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.telephoneLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.ClassNoLB = new System.Windows.Forms.Label();
            this.BdateLB = new System.Windows.Forms.Label();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostCodeLB = new System.Windows.Forms.Label();
            this.FatherNameLB = new System.Windows.Forms.Label();
            this.studentTBLTableAdapter1 = new School.DataSet1TableAdapters.StudentTBLTableAdapter();
            this.ShenasnameLB = new System.Windows.Forms.Label();
            this.CodeMeliLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.ForestGreen;
            this.RegisterButton.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(35, 338);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(144, 37);
            this.RegisterButton.TabIndex = 86;
            this.RegisterButton.Text = "ویرایش";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // telephoneTB
            // 
            this.telephoneTB.Location = new System.Drawing.Point(12, 270);
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(150, 20);
            this.telephoneTB.TabIndex = 84;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(12, 214);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(150, 42);
            this.AddressTB.TabIndex = 83;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(12, 180);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(150, 20);
            this.PostCodeTB.TabIndex = 82;
            // 
            // ClassNoTB
            // 
            this.ClassNoTB.Location = new System.Drawing.Point(62, 137);
            this.ClassNoTB.Name = "ClassNoTB";
            this.ClassNoTB.Size = new System.Drawing.Size(100, 20);
            this.ClassNoTB.TabIndex = 81;
            // 
            // BDateTB
            // 
            this.BDateTB.Location = new System.Drawing.Point(62, 93);
            this.BDateTB.Name = "BDateTB";
            this.BDateTB.Size = new System.Drawing.Size(100, 20);
            this.BDateTB.TabIndex = 79;
            // 
            // FatherNameTB
            // 
            this.FatherNameTB.Location = new System.Drawing.Point(289, 273);
            this.FatherNameTB.Name = "FatherNameTB";
            this.FatherNameTB.Size = new System.Drawing.Size(100, 20);
            this.FatherNameTB.TabIndex = 78;
            // 
            // ShenasnameTB
            // 
            this.ShenasnameTB.Location = new System.Drawing.Point(289, 225);
            this.ShenasnameTB.Name = "ShenasnameTB";
            this.ShenasnameTB.Size = new System.Drawing.Size(100, 20);
            this.ShenasnameTB.TabIndex = 77;
            // 
            // CodeMeliTB
            // 
            this.CodeMeliTB.Location = new System.Drawing.Point(289, 183);
            this.CodeMeliTB.Name = "CodeMeliTB";
            this.CodeMeliTB.Size = new System.Drawing.Size(100, 20);
            this.CodeMeliTB.TabIndex = 76;
            this.CodeMeliTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeMeliTB_KeyDown);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(289, 138);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 75;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(289, 93);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 74;
            this.NameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTB_KeyDown);
            // 
            // telephoneLB
            // 
            this.telephoneLB.AutoSize = true;
            this.telephoneLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.telephoneLB.Location = new System.Drawing.Point(215, 261);
            this.telephoneLB.Name = "telephoneLB";
            this.telephoneLB.Size = new System.Drawing.Size(40, 29);
            this.telephoneLB.TabIndex = 73;
            this.telephoneLB.Text = "تلفن";
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.Location = new System.Drawing.Point(176, 24);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(162, 37);
            this.titleLB.TabIndex = 71;
            this.titleLB.Text = "ویرایش دانش آموز";
            // 
            // ClassNoLB
            // 
            this.ClassNoLB.AutoSize = true;
            this.ClassNoLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClassNoLB.Location = new System.Drawing.Point(171, 128);
            this.ClassNoLB.Name = "ClassNoLB";
            this.ClassNoLB.Size = new System.Drawing.Size(84, 29);
            this.ClassNoLB.TabIndex = 69;
            this.ClassNoLB.Text = "شماره کلاس";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(188, 84);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(67, 29);
            this.BdateLB.TabIndex = 68;
            this.BdateLB.Text = "تاریخ تولد";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLB.Location = new System.Drawing.Point(209, 216);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(46, 29);
            this.AddressLB.TabIndex = 67;
            this.AddressLB.Text = "آدرس";
            // 
            // PostCodeLB
            // 
            this.PostCodeLB.AutoSize = true;
            this.PostCodeLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCodeLB.Location = new System.Drawing.Point(197, 171);
            this.PostCodeLB.Name = "PostCodeLB";
            this.PostCodeLB.Size = new System.Drawing.Size(58, 29);
            this.PostCodeLB.TabIndex = 66;
            this.PostCodeLB.Text = "کدپستی";
            // 
            // FatherNameLB
            // 
            this.FatherNameLB.AutoSize = true;
            this.FatherNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FatherNameLB.Location = new System.Drawing.Point(448, 264);
            this.FatherNameLB.Name = "FatherNameLB";
            this.FatherNameLB.Size = new System.Drawing.Size(51, 29);
            this.FatherNameLB.TabIndex = 65;
            this.FatherNameLB.Text = "نام پدر";
            // 
            // studentTBLTableAdapter1
            // 
            this.studentTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // ShenasnameLB
            // 
            this.ShenasnameLB.AutoSize = true;
            this.ShenasnameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShenasnameLB.Location = new System.Drawing.Point(390, 219);
            this.ShenasnameLB.Name = "ShenasnameLB";
            this.ShenasnameLB.Size = new System.Drawing.Size(109, 29);
            this.ShenasnameLB.TabIndex = 64;
            this.ShenasnameLB.Text = "شماره شناسنامه";
            // 
            // CodeMeliLB
            // 
            this.CodeMeliLB.AutoSize = true;
            this.CodeMeliLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CodeMeliLB.Location = new System.Drawing.Point(446, 174);
            this.CodeMeliLB.Name = "CodeMeliLB";
            this.CodeMeliLB.Size = new System.Drawing.Size(53, 29);
            this.CodeMeliLB.TabIndex = 63;
            this.CodeMeliLB.Text = "کد ملی";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLB.Location = new System.Drawing.Point(414, 129);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(85, 29);
            this.LastNameLB.TabIndex = 62;
            this.LastNameLB.Text = "نام خانوادگی";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLB.Location = new System.Drawing.Point(468, 84);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(31, 29);
            this.nameLB.TabIndex = 61;
            this.nameLB.Text = "نام";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 408);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.telephoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PostCodeTB);
            this.Controls.Add(this.ClassNoTB);
            this.Controls.Add(this.BDateTB);
            this.Controls.Add(this.FatherNameTB);
            this.Controls.Add(this.ShenasnameTB);
            this.Controls.Add(this.CodeMeliTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.telephoneLB);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.ClassNoLB);
            this.Controls.Add(this.BdateLB);
            this.Controls.Add(this.AddressLB);
            this.Controls.Add(this.PostCodeLB);
            this.Controls.Add(this.FatherNameLB);
            this.Controls.Add(this.ShenasnameLB);
            this.Controls.Add(this.CodeMeliLB);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.nameLB);
            this.Name = "editStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش دانش آموز";
            this.Load += new System.EventHandler(this.StudentEditStundent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox telephoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PostCodeTB;
        private System.Windows.Forms.TextBox ClassNoTB;
        private System.Windows.Forms.TextBox BDateTB;
        private System.Windows.Forms.TextBox FatherNameTB;
        private System.Windows.Forms.TextBox ShenasnameTB;
        private System.Windows.Forms.TextBox CodeMeliTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label telephoneLB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label ClassNoLB;
        private System.Windows.Forms.Label BdateLB;
        private System.Windows.Forms.Label AddressLB;
        private System.Windows.Forms.Label PostCodeLB;
        private System.Windows.Forms.Label FatherNameLB;
        private DataSet1TableAdapters.StudentTBLTableAdapter studentTBLTableAdapter1;
        private System.Windows.Forms.Label ShenasnameLB;
        private System.Windows.Forms.Label CodeMeliLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}