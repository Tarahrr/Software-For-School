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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            
            try
            {
           
                if (passTB.Text == passTB2.Text && usernameTB.Text != null)
                {
                    if (studentRBTN.Checked == true) // true is for std
                        usersTableAdapter1.Insert(usernameTB.Text, passTB.Text, "true");
                    else
                        usersTableAdapter1.Insert(usernameTB.Text, passTB.Text, "false");

                }

                else
                    MessageBox.Show("رمز اشتباه است");
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void newUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentTBL' table. You can move, or remove it, as needed.
            this.studentTBLTableAdapter.Fill(this.dataSet1.StudentTBL);

        }
    }
}
