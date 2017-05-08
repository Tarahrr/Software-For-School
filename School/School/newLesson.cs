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
    public partial class newLesson : Form
    {
        public newLesson()
        {
            InitializeComponent();
        }

        private void weekClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Lesson' table. You can move, or remove it, as needed.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lessonTableAdapter.Insert(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox3.Text), textBox2.Text, textBox4.Text);
                MessageBox.Show("ثبت شد");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {

                    string Query = "SELECT * FROM Lesson WHERE lessonNo='" + textBox1.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                    sqlcon.Open();

                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                    if (sqlReader.Read())
                    {

                        textBox3.Text = sqlReader["GPNumber"].ToString();
                        textBox2.Text = sqlReader["lessonName"].ToString();
                        textBox4.Text = sqlReader["paye"].ToString();

                        
                    }
                    sqlReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lessonTableAdapter.UpdateQuery1(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox3.Text), textBox2.Text, textBox4.Text,Convert.ToInt16(textBox1.Text));
                MessageBox.Show("ثبت شد");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lessonTableAdapter.DeleteQuery1(Convert.ToInt16(textBox1.Text));
                MessageBox.Show("حذف شد");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
