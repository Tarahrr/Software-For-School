using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace School
{
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void exitLB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageStudentLB_Click(object sender, EventArgs e)
        {
            editStudentForm form = new editStudentForm();
            form.ShowDialog();
        }

        private void weekStudentsLB_Click(object sender, EventArgs e)
        {
            newGroupDarCi form = new newGroupDarCi();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            changePassword form = new changePassword();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" + logIn.username+ "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {
                    string t = "  شما در قالب ";
                    string s = "    وارد شدید";

                    label1.Text = s+sqlReader["name"].ToString()+"  "+sqlReader["fname"].ToString()+t;
                }
                else
                {
                    label1.Text = " NO ONE";
                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            editStudent form = new editStudent();
            form.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            logIn form = new logIn();
            this.Hide();
            this.Close();

            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            studentEditParent form = new studentEditParent();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            namayeshMeeting form = new namayeshMeeting();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lessonChoose form = new lessonChoose();
            form.ShowDialog();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            karname form = new karname();
            form.ShowDialog();
        }

        private void helpLB_Click(object sender, EventArgs e)
        {
            helpform form = new helpform();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData.save();
        }
    }
}
