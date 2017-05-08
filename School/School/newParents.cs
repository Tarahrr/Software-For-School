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
    public partial class newParents : Form
    {
        public newParents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {
                string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" + textBox1.Text + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {

                    parentsTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("دانش آموزی وجود ندارد ");
                }
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
            

        }

        private void newParents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.parents' table. You can move, or remove it, as needed.
           

        }
    }
}
