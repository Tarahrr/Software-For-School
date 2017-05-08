namespace School
{
    partial class logIn
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
            this.errorLB = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.enterBTN = new System.Windows.Forms.Button();
            this.passTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passLB = new System.Windows.Forms.Label();
            this.usernameLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.dataSet1 = new School.DataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new School.DataSet1TableAdapters.UsersTableAdapter();
            this.studentTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTBLTableAdapter = new School.DataSet1TableAdapters.StudentTBLTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dabirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dabirTableAdapter = new School.DataSet1TableAdapters.DabirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLB
            // 
            this.errorLB.AutoSize = true;
            this.errorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.errorLB.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLB.Location = new System.Drawing.Point(72, 78);
            this.errorLB.Name = "errorLB";
            this.errorLB.Size = new System.Drawing.Size(0, 16);
            this.errorLB.TabIndex = 26;
            this.errorLB.Click += new System.EventHandler(this.errorLB_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.Crimson;
            this.exitBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBTN.Font = new System.Drawing.Font("B Mehr", 14.25F, System.Drawing.FontStyle.Bold);
            this.exitBTN.ForeColor = System.Drawing.Color.White;
            this.exitBTN.Location = new System.Drawing.Point(74, 231);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(111, 49);
            this.exitBTN.TabIndex = 25;
            this.exitBTN.Text = "خروج";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // enterBTN
            // 
            this.enterBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.enterBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.enterBTN.Font = new System.Drawing.Font("B Mehr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.enterBTN.ForeColor = System.Drawing.Color.White;
            this.enterBTN.Location = new System.Drawing.Point(212, 231);
            this.enterBTN.Name = "enterBTN";
            this.enterBTN.Size = new System.Drawing.Size(111, 49);
            this.enterBTN.TabIndex = 24;
            this.enterBTN.Text = "ورود";
            this.enterBTN.UseVisualStyleBackColor = false;
            this.enterBTN.Click += new System.EventHandler(this.enterBTN_Click);
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passTB.Location = new System.Drawing.Point(97, 163);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(151, 26);
            this.passTB.TabIndex = 22;
            this.passTB.TextChanged += new System.EventHandler(this.passTB_TextChanged);
            this.passTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTB_KeyDown);
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernameTB.Location = new System.Drawing.Point(97, 116);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(151, 26);
            this.usernameTB.TabIndex = 21;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            this.usernameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTB_KeyPress);
            // 
            // passLB
            // 
            this.passLB.AutoSize = true;
            this.passLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passLB.Location = new System.Drawing.Point(272, 167);
            this.passLB.Name = "passLB";
            this.passLB.Size = new System.Drawing.Size(60, 19);
            this.passLB.TabIndex = 20;
            this.passLB.Text = ": گذرواژه";
            this.passLB.Click += new System.EventHandler(this.passLB_Click);
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernameLB.Location = new System.Drawing.Point(272, 120);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(75, 19);
            this.usernameLB.TabIndex = 19;
            this.usernameLB.Text = ": نام کاربری";
            this.usernameLB.Click += new System.EventHandler(this.usernameLB_Click);
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLB.ForeColor = System.Drawing.Color.Green;
            this.titleLB.Location = new System.Drawing.Point(78, 47);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(218, 32);
            this.titleLB.TabIndex = 18;
            this.titleLB.Text = "ورود به سامانه مدرسه";
            this.titleLB.Click += new System.EventHandler(this.titleLB_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.dataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.sematDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(398, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 97);
            this.dataGridView1.TabIndex = 29;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sematDataGridViewTextBoxColumn
            // 
            this.sematDataGridViewTextBoxColumn.DataPropertyName = "semat";
            this.sematDataGridViewTextBoxColumn.HeaderText = "semat";
            this.sematDataGridViewTextBoxColumn.Name = "sematDataGridViewTextBoxColumn";
            this.sematDataGridViewTextBoxColumn.ReadOnly = true;
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
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.errorLB);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.enterBTN);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passLB);
            this.Controls.Add(this.usernameLB);
            this.Controls.Add(this.titleLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سامانه";
            this.Load += new System.EventHandler(this.logIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLB;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button enterBTN;
        private System.Windows.Forms.Label passLB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Label titleLB;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource studentTBLBindingSource;
        private DataSet1TableAdapters.StudentTBLTableAdapter studentTBLTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sematDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dabirBindingSource;
        private DataSet1TableAdapters.DabirTableAdapter dabirTableAdapter;
        public System.Windows.Forms.TextBox passTB;
        public System.Windows.Forms.TextBox usernameTB;

    }
}