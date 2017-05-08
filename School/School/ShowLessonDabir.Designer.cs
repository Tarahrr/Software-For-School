namespace School
{
    partial class ShowLessonDabir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gPNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonnNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dabirLessonShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new School.DataSet1();
            this.dabirLessonShowTableAdapter = new School.DataSet1TableAdapters.DabirLessonShowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirLessonShowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(153, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "دروس ارایه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(379, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "کدملی";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(273, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gPNumberDataGridViewTextBoxColumn,
            this.lessonnNoDataGridViewTextBoxColumn,
            this.lessonNameDataGridViewTextBoxColumn,
            this.payeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dabirLessonShowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 242);
            this.dataGridView1.TabIndex = 3;
            // 
            // gPNumberDataGridViewTextBoxColumn
            // 
            this.gPNumberDataGridViewTextBoxColumn.DataPropertyName = "GPNumber";
            this.gPNumberDataGridViewTextBoxColumn.HeaderText = "GPNumber";
            this.gPNumberDataGridViewTextBoxColumn.Name = "gPNumberDataGridViewTextBoxColumn";
            this.gPNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonnNoDataGridViewTextBoxColumn
            // 
            this.lessonnNoDataGridViewTextBoxColumn.DataPropertyName = "LessonnNo";
            this.lessonnNoDataGridViewTextBoxColumn.HeaderText = "LessonnNo";
            this.lessonnNoDataGridViewTextBoxColumn.Name = "lessonnNoDataGridViewTextBoxColumn";
            this.lessonnNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonNameDataGridViewTextBoxColumn
            // 
            this.lessonNameDataGridViewTextBoxColumn.DataPropertyName = "lessonName";
            this.lessonNameDataGridViewTextBoxColumn.HeaderText = "lessonName";
            this.lessonNameDataGridViewTextBoxColumn.Name = "lessonNameDataGridViewTextBoxColumn";
            this.lessonNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payeDataGridViewTextBoxColumn
            // 
            this.payeDataGridViewTextBoxColumn.DataPropertyName = "paye";
            this.payeDataGridViewTextBoxColumn.HeaderText = "paye";
            this.payeDataGridViewTextBoxColumn.Name = "payeDataGridViewTextBoxColumn";
            this.payeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dabirLessonShowBindingSource
            // 
            this.dabirLessonShowBindingSource.DataMember = "DabirLessonShow";
            this.dabirLessonShowBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dabirLessonShowTableAdapter
            // 
            this.dabirLessonShowTableAdapter.ClearBeforeFill = true;
            // 
            // ShowLessonDabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowLessonDabir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دروس ارایه";
            this.Load += new System.EventHandler(this.ShowLessonDabir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabirLessonShowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dabirLessonShowBindingSource;
        private DataSet1TableAdapters.DabirLessonShowTableAdapter dabirLessonShowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonnNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeDataGridViewTextBoxColumn;
    }
}