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
    public partial class MeetingEdit : Form
    {
        public MeetingEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meetingTableAdapter.UpdateQuery1(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text);
            this.Close();
        }

        private void MeetingEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = logIn.username;
        }
    }
}
