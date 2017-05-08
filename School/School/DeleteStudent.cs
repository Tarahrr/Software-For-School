using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void sea_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("ایا مایل به حذف این دانش آموز هستید؟", "اخطار", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                studentTBLTableAdapter.DeleteQuery(codeMeliTB.Text);
                for (int i = 0; i < dataSet1.StudentTBL.Rows.Count; i++)
                {
                    if (dataSet1.StudentTBL.Rows[i][0].ToString() == codeMeliTB.Text)
                    {
                        dataSet1.StudentTBL.Rows[i].Delete();
                        dataGridView1.Refresh();
                        MessageBox.Show("شخص مورد نظر حذف شد");
                    }
                }
            }
            else
            {
                
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            this.studentTBLTableAdapter.Fill(this.dataSet1.StudentTBL);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
          
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("ایا مایل به حذف این دانش آموز هستید؟", "اخطار", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                studentTBLTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
