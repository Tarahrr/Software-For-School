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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
           // this.usersTableAdapter.Fill(this.dataSet1.Users);
            textBox1.Text = logIn.username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == textBox3.Text & textBox1 != null)
                {
                    usersTableAdapter.UpdateQuery1(textBox1.Text, textBox2.Text, textBox1.Text);
                    MessageBox.Show("ویرایش شد");
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
    }
}
