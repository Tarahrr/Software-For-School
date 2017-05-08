namespace School
{
    partial class dabirEditDabir
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dabirBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dabirTableAdapter = new School.DataSet1TableAdapters.DabirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dabirBindingSource
            // 
            this.dabirBindingSource.DataMember = "Dabir";
            this.dabirBindingSource.DataSource = this.dataSet1;
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
            this.button2.Location = new System.Drawing.Point(30, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 126;
            this.button2.Text = "ویرایش دبیر";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupNameTB
            // 
            this.GroupNameTB.Location = new System.Drawing.Point(30, 312);
            this.GroupNameTB.Name = "GroupNameTB";
            this.GroupNameTB.Size = new System.Drawing.Size(120, 20);
            this.GroupNameTB.TabIndex = 125;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(30, 259);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(120, 20);
            this.PostCodeTB.TabIndex = 124;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(30, 195);
            this.addressTB.Multiline = true;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(120, 50);
            this.addressTB.TabIndex = 123;
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(50, 144);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.Size = new System.Drawing.Size(100, 20);
            this.TelephoneTB.TabIndex = 122;
            // 
            // MobileTB
            // 
            this.MobileTB.Location = new System.Drawing.Point(50, 89);
            this.MobileTB.Name = "MobileTB";
            this.MobileTB.Size = new System.Drawing.Size(100, 20);
            this.MobileTB.TabIndex = 121;
            // 
            // TahsilatTB
            // 
            this.TahsilatTB.Location = new System.Drawing.Point(275, 365);
            this.TahsilatTB.Name = "TahsilatTB";
            this.TahsilatTB.Size = new System.Drawing.Size(100, 20);
            this.TahsilatTB.TabIndex = 120;
            // 
            // BdateTB
            // 
            this.BdateTB.Location = new System.Drawing.Point(275, 312);
            this.BdateTB.Name = "BdateTB";
            this.BdateTB.Size = new System.Drawing.Size(100, 20);
            this.BdateTB.TabIndex = 119;
            // 
            // shenasnameTB
            // 
            this.shenasnameTB.Location = new System.Drawing.Point(275, 259);
            this.shenasnameTB.Name = "shenasnameTB";
            this.shenasnameTB.Size = new System.Drawing.Size(100, 20);
            this.shenasnameTB.TabIndex = 118;
            // 
            // CodeMeliTB
            // 
            this.CodeMeliTB.Enabled = false;
            this.CodeMeliTB.Location = new System.Drawing.Point(275, 204);
            this.CodeMeliTB.Name = "CodeMeliTB";
            this.CodeMeliTB.Size = new System.Drawing.Size(100, 20);
            this.CodeMeliTB.TabIndex = 117;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(275, 141);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 116;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(275, 89);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 115;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.Location = new System.Drawing.Point(217, 33);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(75, 37);
            this.titleLB.TabIndex = 114;
            this.titleLB.Text = "ویرایش";
            // 
            // groupNoLB
            // 
            this.groupNoLB.AutoSize = true;
            this.groupNoLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupNoLB.Location = new System.Drawing.Point(156, 301);
            this.groupNoLB.Name = "groupNoLB";
            this.groupNoLB.Size = new System.Drawing.Size(78, 29);
            this.groupNoLB.TabIndex = 113;
            this.groupNoLB.Text = "شماره گروه";
            // 
            // mobileLB
            // 
            this.mobileLB.AutoSize = true;
            this.mobileLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mobileLB.Location = new System.Drawing.Point(181, 89);
            this.mobileLB.Name = "mobileLB";
            this.mobileLB.Size = new System.Drawing.Size(53, 29);
            this.mobileLB.TabIndex = 112;
            this.mobileLB.Text = "موبایل";
            // 
            // tahsialtLB
            // 
            this.tahsialtLB.AutoSize = true;
            this.tahsialtLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tahsialtLB.Location = new System.Drawing.Point(428, 365);
            this.tahsialtLB.Name = "tahsialtLB";
            this.tahsialtLB.Size = new System.Drawing.Size(63, 29);
            this.tahsialtLB.TabIndex = 111;
            this.tahsialtLB.Text = "تحصیلات";
            // 
            // telephoneLB
            // 
            this.telephoneLB.AutoSize = true;
            this.telephoneLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.telephoneLB.Location = new System.Drawing.Point(194, 142);
            this.telephoneLB.Name = "telephoneLB";
            this.telephoneLB.Size = new System.Drawing.Size(40, 29);
            this.telephoneLB.TabIndex = 110;
            this.telephoneLB.Text = "تلفن";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(424, 312);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(67, 29);
            this.BdateLB.TabIndex = 109;
            this.BdateLB.Text = "تاریخ تولد";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLB.Location = new System.Drawing.Point(188, 195);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(46, 29);
            this.AddressLB.TabIndex = 108;
            this.AddressLB.Text = "آدرس";
            // 
            // PostCodeLB
            // 
            this.PostCodeLB.AutoSize = true;
            this.PostCodeLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCodeLB.Location = new System.Drawing.Point(176, 248);
            this.PostCodeLB.Name = "PostCodeLB";
            this.PostCodeLB.Size = new System.Drawing.Size(58, 29);
            this.PostCodeLB.TabIndex = 107;
            this.PostCodeLB.Text = "کدپستی";
            // 
            // ShenasnameLB
            // 
            this.ShenasnameLB.AutoSize = true;
            this.ShenasnameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShenasnameLB.Location = new System.Drawing.Point(382, 259);
            this.ShenasnameLB.Name = "ShenasnameLB";
            this.ShenasnameLB.Size = new System.Drawing.Size(109, 29);
            this.ShenasnameLB.TabIndex = 106;
            this.ShenasnameLB.Text = "شماره شناسنامه";
            // 
            // CodeMeliLB
            // 
            this.CodeMeliLB.AutoSize = true;
            this.CodeMeliLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CodeMeliLB.Location = new System.Drawing.Point(438, 204);
            this.CodeMeliLB.Name = "CodeMeliLB";
            this.CodeMeliLB.Size = new System.Drawing.Size(53, 29);
            this.CodeMeliLB.TabIndex = 105;
            this.CodeMeliLB.Text = "کد ملی";
            // 
            // LastNameLB
            // 
            this.LastNameLB.AutoSize = true;
            this.LastNameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLB.Location = new System.Drawing.Point(406, 135);
            this.LastNameLB.Name = "LastNameLB";
            this.LastNameLB.Size = new System.Drawing.Size(85, 29);
            this.LastNameLB.TabIndex = 104;
            this.LastNameLB.Text = "نام خانوادگی";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameLB.Location = new System.Drawing.Point(460, 89);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(31, 29);
            this.nameLB.TabIndex = 103;
            this.nameLB.Text = "نام";
            // 
            // dabirTableAdapter
            // 
            this.dabirTableAdapter.ClearBeforeFill = true;
            // 
            // dabirEditDabir
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
            this.Name = "dabirEditDabir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش دبیر";
            this.Load += new System.EventHandler(this.dabirEditDabir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource dabirBindingSource;
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
        private DataSet1TableAdapters.DabirTableAdapter dabirTableAdapter;
    }
}