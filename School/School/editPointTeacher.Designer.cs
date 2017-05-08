namespace School
{
    partial class editPointTeacher
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.TextBox();
            this.ssnstdTB = new System.Windows.Forms.TextBox();
            this.ssndabirTB = new System.Windows.Forms.TextBox();
            this.lessonNoTB = new System.Windows.Forms.TextBox();
            this.examNOTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BdateLB = new System.Windows.Forms.Label();
            this.pointTableAdapter = new School.DataSet1TableAdapters.pointTableAdapter();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 92;
            this.button1.Text = "ویرایش";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(143, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 42);
            this.label5.TabIndex = 91;
            this.label5.Text = "ویرایش نمره دهی";
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(157, 326);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(100, 20);
            this.point.TabIndex = 90;
            // 
            // ssnstdTB
            // 
            this.ssnstdTB.Location = new System.Drawing.Point(157, 273);
            this.ssnstdTB.Name = "ssnstdTB";
            this.ssnstdTB.Size = new System.Drawing.Size(100, 20);
            this.ssnstdTB.TabIndex = 89;
            // 
            // ssndabirTB
            // 
            this.ssndabirTB.Enabled = false;
            this.ssndabirTB.Location = new System.Drawing.Point(157, 221);
            this.ssndabirTB.Name = "ssndabirTB";
            this.ssndabirTB.Size = new System.Drawing.Size(100, 20);
            this.ssndabirTB.TabIndex = 88;
            // 
            // lessonNoTB
            // 
            this.lessonNoTB.Location = new System.Drawing.Point(157, 164);
            this.lessonNoTB.Name = "lessonNoTB";
            this.lessonNoTB.Size = new System.Drawing.Size(100, 20);
            this.lessonNoTB.TabIndex = 87;
            // 
            // examNOTB
            // 
            this.examNOTB.Location = new System.Drawing.Point(157, 114);
            this.examNOTB.Name = "examNOTB";
            this.examNOTB.Size = new System.Drawing.Size(100, 20);
            this.examNOTB.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(343, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = ": نمره";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(263, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 84;
            this.label3.Text = ": کد ملی دانش آموز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(305, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = ": کد ملی دبیر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(303, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = ": شماره درس";
            // 
            // BdateLB
            // 
            this.BdateLB.AutoSize = true;
            this.BdateLB.Font = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BdateLB.Location = new System.Drawing.Point(290, 105);
            this.BdateLB.Name = "BdateLB";
            this.BdateLB.Size = new System.Drawing.Size(100, 29);
            this.BdateLB.TabIndex = 81;
            this.BdateLB.Text = ": شماره امتحان";
            // 
            // pointTableAdapter
            // 
            this.pointTableAdapter.ClearBeforeFill = true;
            // 
            // editPointTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.point);
            this.Controls.Add(this.ssnstdTB);
            this.Controls.Add(this.ssndabirTB);
            this.Controls.Add(this.lessonNoTB);
            this.Controls.Add(this.examNOTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BdateLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "editPointTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش نمره";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.TextBox ssnstdTB;
        private System.Windows.Forms.TextBox ssndabirTB;
        private System.Windows.Forms.TextBox lessonNoTB;
        private System.Windows.Forms.TextBox examNOTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BdateLB;
        private DataSet1TableAdapters.pointTableAdapter pointTableAdapter;


    }
}