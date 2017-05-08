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
    public partial class newClass : Form
    {
        public newClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                classTableAdapter.Insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("ثبت شد");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void newClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Class' table. You can move, or remove it, as needed.
        //    this.classTableAdapter.Fill(this.dataSet1.Class);
            // TODO: This line of code loads data into the 'dataSet1.Class1' table. You can move, or remove it, as needed.
//            this.classTableAdapter.Fill(this.dataSet1.Class);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                classTableAdapter.UpdateQuery1(textBox1.Text, textBox2.Text, textBox1.Text);
                MessageBox.Show("ویرایش شد");
                textBox1.Text = "";
                textBox2.Text = "";
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
                classTableAdapter.DeleteQuery1(textBox1.Text);
                MessageBox.Show("حذف شد");
                textBox1.Text = "";
                textBox2.Text = "";
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

                    string Query = "SELECT * FROM Class WHERE classNo='" + textBox1.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                    sqlcon.Open();

                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                    if (sqlReader.Read())
                    {

                        textBox2.Text = sqlReader["paye"].ToString();
                   
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
