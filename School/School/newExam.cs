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
    public partial class newExam : Form
    {
        public newExam()
        {
            InitializeComponent();
        }

        private void newExam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.dataSet1.exam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                examTableAdapter.Insert(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("ثبت شد");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                 
            examTableAdapter.UpdateQuery1(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt16(textBox1.Text));
            MessageBox.Show("ویرایش شد ");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

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
                examTableAdapter.DeleteQuery1(Convert.ToInt16(textBox1.Text));
                MessageBox.Show("حذف شد");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {

                    string Query = "SELECT * FROM exam WHERE examNo='" + textBox1.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                    sqlcon.Open();

                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                    if (sqlReader.Read())
                    {
                        textBox2.Text = sqlReader["lessonName"].ToString(); ;
                        textBox3.Text = sqlReader["dabirName"].ToString(); ;
                        textBox4.Text = sqlReader["date"].ToString(); ;
                        textBox5.Text = sqlReader["time"].ToString(); ;


                    }
                    sqlReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

