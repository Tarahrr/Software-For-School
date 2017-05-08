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
    public partial class DabirMenu : Form
    {
        public DabirMenu()
        {
            InitializeComponent();
        }

        private void exitLB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            editTeacher form = new editTeacher();
            form.ShowDialog();
        }

        private void weekTeacherLB_Click(object sender, EventArgs e)
        {
            namayeshDorous form = new namayeshDorous();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            changePassword form = new changePassword();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ClassMember form = new  ClassMember();
            form.ShowDialog();
        }

        private void setPointTeacherLB_Click(object sender, EventArgs e)
        {
            pointTeacher form = new pointTeacher();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            editPointTeacher form = new editPointTeacher();
            form.ShowDialog();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            namayash_nomarat form = new namayash_nomarat();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            changePassword form = new changePassword();
            form.ShowDialog();
        }

        private void lessonTeacherLB_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            logIn form = new logIn();
            this.Hide();
            this.Close();

            form.ShowDialog();
        }

        private void DabirMenu_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {


                  string Query = "SELECT * FROM Dabir WHERE ssn='" + logIn.username+ "'";
                   SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                    sqlcon.Open();

                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                    if (sqlReader.Read()){
                    string t = "  شما در قالب ";
                    string s = "    وارد شدید";
                    label1.Text = s+sqlReader["name"].ToString() + "  " + sqlReader["fname"].ToString()+t;
                     }
                     else
                    {
                        label1.Text = logIn.username;
                            //label1.Text = " NO ONE";
                     }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            MeetingRegister form = new MeetingRegister();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MeetingEdit form = new MeetingEdit();
            form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            dabirEditDabir form = new dabirEditDabir();
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ShowLessonDabir form = new ShowLessonDabir();
            form.ShowDialog();
        }

        private void helpLB_Click(object sender, EventArgs e)
        {
            helpform form = new helpform();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData.save();
        }
    }
}
