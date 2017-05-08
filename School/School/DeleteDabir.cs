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
    public partial class DeleteDabir : Form
    {
        public DeleteDabir()
        {
            InitializeComponent();
        }

        private void DeleteDabir_Load(object sender, EventArgs e)
        {
            this.dabirTableAdapter.Fill(dataSet1.Dabir);
        }

        private void sea_Click(object sender, EventArgs e)
        {

        }

        private void sea_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("ایا مایل به حذف این دبیر هستید؟", "اخطار", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                dabirTableAdapter.DeleteQuery1(codeMeliTB.Text);
                for (int i = 0; i < dataSet1.Dabir.Rows.Count; i++)
                {
                    if (dataSet1.Dabir.Rows[i][0].ToString() == codeMeliTB.Text)
                    {
                        dataSet1.Dabir.Rows[i].Delete();
                        dataGridView1.Refresh();
                        MessageBox.Show("شخص مورد نظر حذف شد");
                    }
                }
            }
            else
            {

            }
        }
    }
}
