namespace School
{
    partial class editTeacher
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
            this.dabirTableAdapter = new School.DataSet1TableAdapters.DabirTableAdapter();
            this.dataSet1 = new School.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupNameTB = new System.Windows.Forms.TextBox();
            this.PostCodeTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.TelephoneTB = new System.Windows.Forms.TextBox();
            this.MobileTB = new System.Windows.Forms.TextBox();
            this.TahsilatTB = new System.Windows.Forms.TextBox();
            this.BdateTB = new System.Windows.Forms.TextBox();
            this.shenasnameTB = new System.Windows.Forms.TextBox();
            this.CodeMeliTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.titleLB = new System.Windows.Forms.Label();
            this.groupNoLB = new System.Windows.Forms.Label();
            this.mobileLB = new System.Windows.Forms.Label();
            this.tahsialtLB = new System.Windows.Forms.Label();
            this.telephoneLB = new System.Windows.Forms.Label();
            this.BdateLB = new System.Windows.Forms.Label();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostCodeLB = new System.Windows.Forms.Label();
            this.ShenasnameLB = new System.Windows.Forms.Label();
            this.CodeMeliLB = new System.Windows.Forms.Label();
            this.LastNameLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.dabirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dabirTableAdapter
            // 
            this.dabirTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 102;
            this.button2.Text = "ویرایش دبیر";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupNameTB
            // 
            this.GroupNameTB.Location = new System.Drawing.Point(30, 308);
            this.GroupNameTB.Name = "GroupNameTB";
            this.GroupNameTB.Size = new System.Drawing.Size(120, 20);
            this.GroupNameTB.TabIndex = 99;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(30, 255);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(120, 20);
            this.PostCodeTB.TabIndex = 98;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(30, 191);
            this.addressTB.Multiline = true;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(120, 50);
            this.addressTB.TabIndex = 97;
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(50, 140);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.Size = new System.Drawing.Size(100, 20);
            this.TelephoneTB.TabIndex = 96;
            // 
            // MobileTB
            // 
            this.MobileTB.Location = new System.Drawing.Point(50, 85);
            this.MobileTB.Name = "MobileTB";
            this.MobileTB.Size = new System.Drawing.Size(100, 20);
            this.MobileTB.TabIndex = 95;
            // 
            // TahsilatTB
            // 
            this.TahsilatTB.Location = new System.Drawing.Point(275, 361);
            this.TahsilatTB.Name = "TahsilatTB";
            this.TahsilatTB.Size = new System.Drawing.Size(100, 20);
            this.TahsilatTB.TabIndex = 94;
            // 
            // BdateTB
            // 
            this.BdateTB.Location = new System.Drawing.Point(275, 308);
            this.BdateTB.Name = "BdateTB";
            this.BdateTB.Size = new System.Drawing.Size(100, 20);
            this.BdateTB.TabIndex = 92;
            // 
            // shenasnameTB
            // 
            this.shenasnameTB.Location = new System.Drawing.Point(275, 255);
            this.shenasnameTB.Name = "shenasnameTB";
            this.shenasnameTB.Size = new System.Drawing.Size(100, 20);
            this.shenasnameTB.TabIndex = 91;
            // 
            // CodeMeliTB
            // 
            this.CodeMeliTB.Location = new System.Drawing.Point(275, 200);
            this.CodeMeliTB.Name = "CodeMeliTB";
            this.CodeMeliTB.Size = new System.Drawing.Size(100, 20);
            this.CodeMeliTB.TabIndex = 90;
            this.CodeMeliTB.TextChanged += new System.EventHandler(this.CodeMeliTB_TextChanged);
            this.CodeMeliTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeMeliTB_KeyDown);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(275, 137);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 89;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(275, 85);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 88;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.Location = new System.Drawing.Point(217, 29);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(75, 37);
            this.titleLB.TabIndex = 87;
            this.titleLB.Text = "ویرایش";
            // 
            // groupNoLB
            // 
            this.groupNoLB.AutoSize = true;
            this.groupNoLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupNoLB.Location = new System.Drawing.Point(156, 297);
            this.groupNoLB.Name = "groupNoLB";
            this.groupNoLB.Size = new System.Drawing.Size(78, 29);
            this.groupNoLB.TabIndex = 86;
            this.groupNoLB.Text = "شماره گروه";
            // 
            // mobileLB
            // 
            this.mobileLB.AutoSize = true;
            this.mobileLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mobileLB.Location = new System.Drawing.Point(181, 85);
            this.mobileLB.Name = "mobileLB";
            this.mobileLB.Size = new System.Drawing.Size(53, 29);
            this.mobileLB.TabIndex = 85;
            this.mobileLB.Text = "موبایل";
            // 
            // tahsialtLB
            // 
            this.tahsialtLB.AutoSize = true;
            this.tahsialtLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tahsialtLB.Location = new System.Drawing.Point(428, 361);
            this.tahsialtLB.Name = "tahsialtLB";
            this.tahsialtLB.Size = new System.Drawing.Size(63, 29);
            this.tahsialtLB.TabIndex = 84;
            this.tahsialtLB.Text = "تحصیلات";
            // 
            // telephoneLB
            // 
            this.telephoneLB.AutoSize = true;
            this.telephoneLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.telephoneLB.Location = new System.Drawing.Point(194, 138);
            this.telephoneLB.Name = "telephoneLB";
            this.telephoneLB.Size = new System.Drawing.Size(40, 29);
            this.telephoneLB.TabIndex = 83;
            this.telephoneLB.Text = "تلفن";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(424, 308);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(67, 29);
            this.BdateLB.TabIndex = 81;
            this.BdateLB.Text = "تاریخ تولد";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLB.Location = new System.Drawing.Point(188, 191);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(46, 29);
            this.AddressLB.TabIndex = 80;
            this.AddressLB.Text = "آدرس";
            // 
            // PostCodeLB
            // 
            this.PostCodeLB.AutoSize = true;
            this.PostCodeLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCodeLB.Location = new System.Drawing.Point(176, 244);
            this.PostCodeLB.Name = "PostCodeLB";
            this.PostCodeLB.Size = new System.Drawing.Size(58, 29);
            this.PostCodeLB.TabIndex = 79;
            this.PostCodeLB.Text = "کدپستی";
            // 
            // ShenasnameLB
            // 
            this.ShenasnameLB.AutoSize = true;
            this.ShenasnameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShenasnameLB.Location = new System.Drawing.Point(382, 255);
            this.ShenasnameLB.Name = "ShenasnameLB";
            this.ShenasnameLB.Size = new System.Drawing.Size(109, 29);
            this.ShenasnameLB.TabIndex = 78;
            this.ShenasnameLB.Text = "شماره شناسنامه";
            // 
            // CodeMeliLB
            // 
            this.CodeMeliLB.AutoSize = true;
            this.CodeMeliLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CodeMeliLB.Location = new System.Drawing.Point(438, 200);
            this.CodeMeliLB.Name = "CodeMeliLB";
            this.CodeMeliLB.Size = new System.Drawing.Size(53, 29);
            this.CodeMeliLB.TabIndex = 77;
            this.CodeMeliLB.Text = "کد ملی";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLB.Location = new System.Drawing.Point(406, 131);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(85, 29);
            this.LastNameLB.TabIndex = 76;
            this.LastNameLB.Text = "نام خانوادگی";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLB.Location = new System.Drawing.Point(460, 85);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(31, 29);
            this.nameLB.TabIndex = 75;
            this.nameLB.Text = "نام";
            // 
            // dabirBindingSource
            // 
            this.dabirBindingSource.DataMember = "Dabir";
            this.dabirBindingSource.DataSource = this.dataSet1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupNameTB);
            this.Controls.Add(this.PostCodeTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.TelephoneTB);
            this.Controls.Add(this.MobileTB);
            this.Controls.Add(this.TahsilatTB);
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
            this.Name = "editTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش دبیر";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.DabirTableAdapter dabirTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox GroupNameTB;
        private System.Windows.Forms.TextBox PostCodeTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox TelephoneTB;
        private System.Windows.Forms.TextBox MobileTB;
        private System.Windows.Forms.TextBox TahsilatTB;
        private System.Windows.Forms.TextBox BdateTB;
        private System.Windows.Forms.TextBox shenasnameTB;
        private System.Windows.Forms.TextBox CodeMeliTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label groupNoLB;
        private System.Windows.Forms.Label mobileLB;
        private System.Windows.Forms.Label tahsialtLB;
        private System.Windows.Forms.Label telephoneLB;
        private System.Windows.Forms.Label BdateLB;
        private System.Windows.Forms.Label AddressLB;
        private System.Windows.Forms.Label PostCodeLB;
        private System.Windows.Forms.Label ShenasnameLB;
        private System.Windows.Forms.Label CodeMeliLB;
        private System.Windows.Forms.Label LastNameLB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.BindingSource dabirBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;



    }
}