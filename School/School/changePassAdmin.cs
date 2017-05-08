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
    public partial class changePassAdmin : Form
    {
        public changePassAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == textBox3.Text & textBox1 != null)
                {
                    usersTableAdapter.UpdateQuery1(textBox1.Text, textBox2.Text, textBox1.Text);
                    this.Close();
                }
                else
                {
                    label4.Text = " کذر واژه نادرست است";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changePassAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
