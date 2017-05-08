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
    public partial class editPointTeacher : Form
    {
        public editPointTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pointTableAdapter.UpdateQuery2(Convert.ToInt16(examNOTB.Text), Convert.ToInt16(lessonNoTB.Text), ssndabirTB.Text, ssnstdTB.Text, point.Text, Convert.ToInt16(examNOTB.Text));
                MessageBox.Show("ویرایش شد");
                examNOTB.Text = "";
                lessonNoTB.Text = "";
                ssnstdTB.Text = "";
                point.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
