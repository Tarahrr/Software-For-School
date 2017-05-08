namespace School
{
    partial class newStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newStudent));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.titleLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassNoLB = new System.Windows.Forms.Label();
            this.BdateLB = new System.Windows.Forms.Label();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostCodeLB = new System.Windows.Forms.Label();
            this.FatherNameLB = new System.Windows.Forms.Label();
            this.CodeMeliLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.telephoneLB = new System.Windows.Forms.Label();
            this.ShenasnameLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.CodeMeliTB = new System.Windows.Forms.TextBox();
            this.ShenasnameTB = new System.Windows.Forms.TextBox();
            this.FatherNameTB = new System.Windows.Forms.TextBox();
            this.BDateTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.ClassNoTB = new System.Windows.Forms.TextBox();
            this.PostCodeTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.telephoneTB = new System.Windows.Forms.TextBox();
            this.ChoosePicture = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.studentTBLTableAdapter1 = new School.DataSet1TableAdapters.StudentTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.Location = new System.Drawing.Point(177, 27);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(158, 37);
            this.titleLB.TabIndex = 43;
            this.titleLB.Text = "ثبت نام دانش آموز";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClassNoLB
            // 
            this.ClassNoLB.AutoSize = true;
            this.ClassNoLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClassNoLB.Location = new System.Drawing.Point(410, 402);
            this.ClassNoLB.Name = "ClassNoLB";
            this.ClassNoLB.Size = new System.Drawing.Size(84, 29);
            this.ClassNoLB.TabIndex = 30;
            this.ClassNoLB.Text = "شماره کلاس";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(418, 312);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(67, 29);
            this.BdateLB.TabIndex = 29;
            this.BdateLB.Text = "تاریخ تولد";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLB.Location = new System.Drawing.Point(191, 320);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(46, 29);
            this.AddressLB.TabIndex = 28;
            this.AddressLB.Text = "آدرس";
            // 
            // PostCodeLB
            // 
            this.PostCodeLB.AutoSize = true;
            this.PostCodeLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCodeLB.Location = new System.Drawing.Point(179, 275);
            this.PostCodeLB.Name = "PostCodeLB";
            this.PostCodeLB.Size = new System.Drawing.Size(58, 29);
            this.PostCodeLB.TabIndex = 27;
            this.PostCodeLB.Text = "کدپستی";
            // 
            // FatherNameLB
            // 
            this.FatherNameLB.AutoSize = true;
            this.FatherNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FatherNameLB.Location = new System.Drawing.Point(434, 267);
            this.FatherNameLB.Name = "FatherNameLB";
            this.FatherNameLB.Size = new System.Drawing.Size(51, 29);
            this.FatherNameLB.TabIndex = 26;
            this.FatherNameLB.Text = "نام پدر";
            // 
            // CodeMeliLB
            // 
            this.CodeMeliLB.AutoSize = true;
            this.CodeMeliLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CodeMeliLB.Location = new System.Drawing.Point(432, 177);
            this.CodeMeliLB.Name = "CodeMeliLB";
            this.CodeMeliLB.Size = new System.Drawing.Size(53, 29);
            this.CodeMeliLB.TabIndex = 24;
            this.CodeMeliLB.Text = "کد ملی";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLB.Location = new System.Drawing.Point(400, 132);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(85, 29);
            this.LastNameLB.TabIndex = 23;
            this.LastNameLB.Text = "نام خانوادگی";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLB.Location = new System.Drawing.Point(454, 87);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(31, 29);
            this.nameLB.TabIndex = 22;
            this.nameLB.Text = "نام";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.emailLB.Location = new System.Drawing.Point(446, 357);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(48, 29);
            this.emailLB.TabIndex = 44;
            this.emailLB.Text = "ایمیل";
            // 
            // telephoneLB
            // 
            this.telephoneLB.AutoSize = true;
            this.telephoneLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.telephoneLB.Location = new System.Drawing.Point(197, 365);
            this.telephoneLB.Name = "telephoneLB";
            this.telephoneLB.Size = new System.Drawing.Size(40, 29);
            this.telephoneLB.TabIndex = 46;
            this.telephoneLB.Text = "تلفن";
            // 
            // ShenasnameLB
            // 
            this.ShenasnameLB.AutoSize = true;
            this.ShenasnameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShenasnameLB.Location = new System.Drawing.Point(376, 222);
            this.ShenasnameLB.Name = "ShenasnameLB";
            this.ShenasnameLB.Size = new System.Drawing.Size(109, 29);
            this.ShenasnameLB.TabIndex = 25;
            this.ShenasnameLB.Text = "شماره شناسنامه";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(273, 96);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 48;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(273, 141);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 49;
            // 
            // CodeMeliTB
            // 
            this.CodeMeliTB.Location = new System.Drawing.Point(273, 186);
            this.CodeMeliTB.Name = "CodeMeliTB";
            this.CodeMeliTB.Size = new System.Drawing.Size(100, 20);
            this.CodeMeliTB.TabIndex = 50;
            // 
            // ShenasnameTB
            // 
            this.ShenasnameTB.Location = new System.Drawing.Point(273, 228);
            this.ShenasnameTB.Name = "ShenasnameTB";
            this.ShenasnameTB.Size = new System.Drawing.Size(100, 20);
            this.ShenasnameTB.TabIndex = 51;
            // 
            // FatherNameTB
            // 
            this.FatherNameTB.Location = new System.Drawing.Point(273, 276);
            this.FatherNameTB.Name = "FatherNameTB";
            this.FatherNameTB.Size = new System.Drawing.Size(100, 20);
            this.FatherNameTB.TabIndex = 52;
            // 
            // BDateTB
            // 
            this.BDateTB.Location = new System.Drawing.Point(273, 321);
            this.BDateTB.Name = "BDateTB";
            this.BDateTB.Size = new System.Drawing.Size(100, 20);
            this.BDateTB.TabIndex = 53;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(273, 366);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 54;
            // 
            // ClassNoTB
            // 
            this.ClassNoTB.Location = new System.Drawing.Point(273, 411);
            this.ClassNoTB.Name = "ClassNoTB";
            this.ClassNoTB.Size = new System.Drawing.Size(100, 20);
            this.ClassNoTB.TabIndex = 55;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(28, 284);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(150, 20);
            this.PostCodeTB.TabIndex = 56;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(28, 318);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(150, 42);
            this.AddressTB.TabIndex = 57;
            // 
            // telephoneTB
            // 
            this.telephoneTB.Location = new System.Drawing.Point(28, 374);
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(150, 20);
            this.telephoneTB.TabIndex = 58;
            // 
            // ChoosePicture
            // 
            this.ChoosePicture.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChoosePicture.Location = new System.Drawing.Point(53, 217);
            this.ChoosePicture.Name = "ChoosePicture";
            this.ChoosePicture.Size = new System.Drawing.Size(112, 34);
            this.ChoosePicture.TabIndex = 59;
            this.ChoosePicture.Text = "انتخاب عکس";
            this.ChoosePicture.UseVisualStyleBackColor = true;
            this.ChoosePicture.Click += new System.EventHandler(this.ChoosePicture_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.ForestGreen;
            this.RegisterButton.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(66, 458);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(144, 37);
            this.RegisterButton.TabIndex = 60;
            this.RegisterButton.Text = "ثبت دانش آموز";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // studentTBLTableAdapter1
            // 
            this.studentTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // newStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 517);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ChoosePicture);
            this.Controls.Add(this.telephoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PostCodeTB);
            this.Controls.Add(this.ClassNoTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.BDateTB);
            this.Controls.Add(this.FatherNameTB);
            this.Controls.Add(this.ShenasnameTB);
            this.Controls.Add(this.CodeMeliTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.telephoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClassNoLB);
            this.Controls.Add(this.BdateLB);
            this.Controls.Add(this.AddressLB);
            this.Controls.Add(this.PostCodeLB);
            this.Controls.Add(this.FatherNameLB);
            this.Controls.Add(this.ShenasnameLB);
            this.Controls.Add(this.CodeMeliLB);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.nameLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.newStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ClassNoLB;
        private System.Windows.Forms.Label BdateLB;
        private System.Windows.Forms.Label AddressLB;
        private System.Windows.Forms.Label PostCodeLB;
        private System.Windows.Forms.Label FatherNameLB;
        private System.Windows.Forms.Label CodeMeliLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label nameLB;
        private DataSet1TableAdapters.StudentTBLTableAdapter studentTBLTableAdapter1;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label telephoneLB;
        private System.Windows.Forms.Label ShenasnameLB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox CodeMeliTB;
        private System.Windows.Forms.TextBox ShenasnameTB;
        private System.Windows.Forms.TextBox FatherNameTB;
        private System.Windows.Forms.TextBox BDateTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox ClassNoTB;
        private System.Windows.Forms.TextBox PostCodeTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox telephoneTB;
        private System.Windows.Forms.Button ChoosePicture;
        private System.Windows.Forms.Button RegisterButton;

    }
}