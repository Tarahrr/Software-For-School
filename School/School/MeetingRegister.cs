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
    public partial class MeetingRegister : Form
    {
        public MeetingRegister()
        {
            InitializeComponent();
        }

        private void MeetingRegister_Load(object sender, EventArgs e)
        {
            textBox1.Text = logIn.username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                meetingTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
