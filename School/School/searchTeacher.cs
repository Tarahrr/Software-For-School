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
    public partial class searchTeacher : Form
    {
        public searchTeacher()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dabirBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void codepostiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FamilyTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void shenasnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void codeMeliTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void sea_Click(object sender, EventArgs e)
        {
            dabirTableAdapter.FillByData(dataSet1.Dabir, codeMeliTB.Text, NameTB.Text, FamilyTB.Text, codepostiTB.Text, shenasnameTB.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
