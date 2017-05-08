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
    public partial class namayeshDaneshAmuz : Form
    {
        public namayeshDaneshAmuz()
        {
            InitializeComponent();
        }

        private void namayeshDaneshAmuz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentTBL' table. You can move, or remove it, as needed.
            this.studentTBLTableAdapter.Fill(this.dataSet1.StudentTBL);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
               
                
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sea_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
               // pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\" + dataGridView1.Rows[e.RowIndex].Cells["picture"].Value.ToString());
            

        }
    }
}
