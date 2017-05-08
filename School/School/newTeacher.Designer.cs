namespace School
{
    partial class newTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTeacher));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.telephoneLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.BdateLB = new System.Windows.Forms.Label();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostCodeLB = new System.Windows.Forms.Label();
            this.ShenasnameLB = new System.Windows.Forms.Label();
            this.CodeMeliLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.tahsialtLB = new System.Windows.Forms.Label();
            this.mobileLB = new System.Windows.Forms.Label();
            this.groupNoLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.CodeMeliTB = new System.Windows.Forms.TextBox();
            this.shenasnameTB = new System.Windows.Forms.TextBox();
            this.BdateTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.TahsilatTB = new System.Windows.Forms.TextBox();
            this.MobileTB = new System.Windows.Forms.TextBox();
            this.TelephoneTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.PostCodeTB = new System.Windows.Forms.TextBox();
            this.GroupNameTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet1 = new School.DataSet1();
            this.dabirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dabirTableAdapter = new School.DataSet1TableAdapters.DabirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // telephoneLB
            // 
            this.telephoneLB.AutoSize = true;
            this.telephoneLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.telephoneLB.Location = new System.Drawing.Point(452, 438);
            this.telephoneLB.Name = "telephoneLB";
            this.telephoneLB.Size = new System.Drawing.Size(40, 29);
            this.telephoneLB.TabIndex = 55;
            this.telephoneLB.Text = "تلفن";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.emailLB.Location = new System.Drawing.Point(444, 300);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(48, 29);
            this.emailLB.TabIndex = 54;
            this.emailLB.Text = "ایمیل";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(425, 254);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(67, 29);
            this.BdateLB.TabIndex = 53;
            this.BdateLB.Text = "تاریخ تولد";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLB.Location = new System.Drawing.Point(181, 279);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(46, 29);
            this.AddressLB.TabIndex = 52;
            this.AddressLB.Text = "آدرس";
            // 
            // PostCodeLB
            // 
            this.PostCodeLB.AutoSize = true;
            this.PostCodeLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCodeLB.Location = new System.Drawing.Point(181, 338);
            this.PostCodeLB.Name = "PostCodeLB";
            this.PostCodeLB.Size = new System.Drawing.Size(58, 29);
            this.PostCodeLB.TabIndex = 51;
            this.PostCodeLB.Text = "کدپستی";
            // 
            // ShenasnameLB
            // 
            this.ShenasnameLB.AutoSize = true;
            this.ShenasnameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShenasnameLB.Location = new System.Drawing.Point(383, 208);
            this.ShenasnameLB.Name = "ShenasnameLB";
            this.ShenasnameLB.Size = new System.Drawing.Size(109, 29);
            this.ShenasnameLB.TabIndex = 50;
            this.ShenasnameLB.Text = "شماره شناسنامه";
            // 
            // CodeMeliLB
            // 
            this.CodeMeliLB.AutoSize = true;
            this.CodeMeliLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CodeMeliLB.Location = new System.Drawing.Point(439, 162);
            this.CodeMeliLB.Name = "CodeMeliLB";
            this.CodeMeliLB.Size = new System.Drawing.Size(53, 29);
            this.CodeMeliLB.TabIndex = 49;
            this.CodeMeliLB.Text = "کد ملی";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLB.Location = new System.Drawing.Point(407, 116);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(85, 29);
            this.LastNameLB.TabIndex = 48;
            this.LastNameLB.Text = "نام خانوادگی";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLB.Location = new System.Drawing.Point(461, 70);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(31, 29);
            this.nameLB.TabIndex = 47;
            this.nameLB.Text = "نام";
            // 
            // tahsialtLB
            // 
            this.tahsialtLB.AutoSize = true;
            this.tahsialtLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tahsialtLB.Location = new System.Drawing.Point(429, 346);
            this.tahsialtLB.Name = "tahsialtLB";
            this.tahsialtLB.Size = new System.Drawing.Size(63, 29);
            this.tahsialtLB.TabIndex = 56;
            this.tahsialtLB.Text = "تحصیلات";
            // 
            // mobileLB
            // 
            this.mobileLB.AutoSize = true;
            this.mobileLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mobileLB.Location = new System.Drawing.Point(439, 392);
            this.mobileLB.Name = "mobileLB";
            this.mobileLB.Size = new System.Drawing.Size(53, 29);
            this.mobileLB.TabIndex = 57;
            this.mobileLB.Text = "موبایل";
            // 
            // groupNoLB
            // 
            this.groupNoLB.AutoSize = true;
            this.groupNoLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupNoLB.Location = new System.Drawing.Point(169, 388);
            this.groupNoLB.Name = "groupNoLB";
            this.groupNoLB.Size = new System.Drawing.Size(78, 29);
            this.groupNoLB.TabIndex = 58;
            this.groupNoLB.Text = "شماره گروه";
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.Location = new System.Drawing.Point(219, 26);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(110, 37);
            this.titleLB.TabIndex = 59;
            this.titleLB.Text = "ثبت نام  دبیر";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(277, 79);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 60;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(277, 125);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 61;
            // 
            // CodeMeliTB
            // 
            this.CodeMeliTB.Location = new System.Drawing.Point(277, 171);
            this.CodeMeliTB.Name = "CodeMeliTB";
            this.CodeMeliTB.Size = new System.Drawing.Size(100, 20);
            this.CodeMeliTB.TabIndex = 62;
            // 
            // shenasnameTB
            // 
            this.shenasnameTB.Location = new System.Drawing.Point(277, 214);
            this.shenasnameTB.Name = "shenasnameTB";
            this.shenasnameTB.Size = new System.Drawing.Size(100, 20);
            this.shenasnameTB.TabIndex = 63;
            // 
            // BdateTB
            // 
            this.BdateTB.Location = new System.Drawing.Point(277, 263);
            this.BdateTB.Name = "BdateTB";
            this.BdateTB.Size = new System.Drawing.Size(100, 20);
            this.BdateTB.TabIndex = 64;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(277, 306);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 65;
            // 
            // TahsilatTB
            // 
            this.TahsilatTB.Location = new System.Drawing.Point(277, 352);
            this.TahsilatTB.Name = "TahsilatTB";
            this.TahsilatTB.Size = new System.Drawing.Size(100, 20);
            this.TahsilatTB.TabIndex = 66;
            // 
            // MobileTB
            // 
            this.MobileTB.Location = new System.Drawing.Point(277, 401);
            this.MobileTB.Name = "MobileTB";
            this.MobileTB.Size = new System.Drawing.Size(100, 20);
            this.MobileTB.TabIndex = 67;
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(277, 447);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.Size = new System.Drawing.Size(100, 20);
            this.TelephoneTB.TabIndex = 68;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(43, 279);
            this.addressTB.Multiline = true;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(120, 50);
            this.addressTB.TabIndex = 69;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(43, 344);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(120, 20);
            this.PostCodeTB.TabIndex = 70;
            // 
            // GroupNameTB
            // 
            this.GroupNameTB.Location = new System.Drawing.Point(43, 397);
            this.GroupNameTB.Name = "GroupNameTB";
            this.GroupNameTB.Size = new System.Drawing.Size(120, 20);
            this.GroupNameTB.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(55, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 73;
            this.button1.Text = "انتخاب عکس";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(32, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 74;
            this.button2.Text = "ثبت دبیر";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dabirBindingSource
            // 
            this.dabirBindingSource.DataMember = "Dabir";
            this.dabirBindingSource.DataSource = this.dataSet1;
            // 
            // dabirTableAdapter
            // 
            this.dabirTableAdapter.ClearBeforeFill = true;
            // 
            // newTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupNameTB);
            this.Controls.Add(this.PostCodeTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.TelephoneTB);
            this.Controls.Add(this.MobileTB);
            this.Controls.Add(this.TahsilatTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.BdateTB);
            this.Controls.Add(this.shenasnameTB);
            this.Controls.Add(this.CodeMeliTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.groupNoLB);
            this.Controls.Add(this.mobileLB);
            this.Controls.Add(this.tahsialtLB);
            this.Controls.Add(this.telephoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.BdateLB);
            this.Controls.Add(this.AddressLB);
            this.Controls.Add(this.PostCodeLB);
            this.Controls.Add(this.ShenasnameLB);
            this.Controls.Add(this.CodeMeliLB);
            this.Controls.Add(this.LastNameLB);
            this.Controls.Add(this.nameLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت دبیر";
            this.Load += new System.EventHandler(this.newTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label telephoneLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label BdateLB;
        private System.Windows.Forms.Label AddressLB;
        private System.Windows.Forms.Label PostCodeLB;
        private System.Windows.Forms.Label ShenasnameLB;
        private System.Windows.Forms.Label CodeMeliLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label tahsialtLB;
        private System.Windows.Forms.Label mobileLB;
        private System.Windows.Forms.Label groupNoLB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox CodeMeliTB;
        private System.Windows.Forms.TextBox shenasnameTB;
        private System.Windows.Forms.TextBox BdateTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox TahsilatTB;
        private System.Windows.Forms.TextBox MobileTB;
        private System.Windows.Forms.TextBox TelephoneTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox PostCodeTB;
        private System.Windows.Forms.TextBox GroupNameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dabirBindingSource;
        private DataSet1TableAdapters.DabirTableAdapter dabirTableAdapter;
    }
}