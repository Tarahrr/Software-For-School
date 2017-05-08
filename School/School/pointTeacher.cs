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
    public partial class pointTeacher : Form
    {
        public pointTeacher()
        {
            InitializeComponent();
        }
        
        private void pointTeacher_Load(object sender, EventArgs e)
        {

            ssndabirTB.Text = logIn.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pointTableAdapter.Insert(Convert.ToInt16(examNOTB.Text), Convert.ToInt16(lessonNoTB.Text), ssndabirTB.Text, ssnstdTB.Text, pointTB.Text);
                MessageBox.Show("ثبت شد");
                examNOTB.Text="";
                lessonNoTB.Text="";
                ssnstdTB.Text="";
                pointTB.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM point WHERE examNo='" + examNOTB.Text + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {

                    ssndabirTB.Text = sqlReader["ssnDabir"].ToString();
                    lessonNoTB.Text = sqlReader["lessonNo"].ToString();
                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private void examNOTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
