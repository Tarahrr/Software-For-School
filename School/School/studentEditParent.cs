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
    public partial class studentEditParent : Form
    {
        public studentEditParent()
        {
            InitializeComponent();
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM parents WHERE ssnStudent='" + logIn.username + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {
                    textBox1.Text = logIn.username;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                parentsTableAdapter.UpdateQuery1(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text);
                MessageBox.Show("ویرایش شد");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentEditParent_Load(object sender, EventArgs e)
        {
            load_tuple();
        }
    }
}
