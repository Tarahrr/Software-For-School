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
    public partial class editParents : Form
    {
        public editParents()
        {
            InitializeComponent();
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM parents WHERE ssnStudent='" + textBox1.Text + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {

                    textBox2.Text = sqlReader["motherMobile"].ToString();
                    textBox3.Text = sqlReader["fatherMobile"].ToString();
                    textBox4.Text = sqlReader["motherWorkAdress"].ToString();
                    textBox5.Text = sqlReader["fatherWorkAdress"].ToString();
                   
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
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                load_tuple();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                parentsTableAdapter.UpdateQuery1(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text);
                MessageBox.Show("ویرایش شد");
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

        private void editParents_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                parentsTableAdapter.DeleteQuery1(textBox1.Text);
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
    }
}
