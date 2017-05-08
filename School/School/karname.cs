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
    public partial class karname : Form
    {
        public karname()
        {
            InitializeComponent();
        }

        private void karname_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.KarnameLesson' table. You can move, or remove it, as needed.
            this.karnameLessonTableAdapter.Fill(this.dataSet1.KarnameLesson);
            
               SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
               try
               {
                 string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" + logIn.username + "'";
                 SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                 sqlcon.Open();
                 SqlDataReader sqlReader = sqlcom.ExecuteReader();
                 if (sqlReader.Read())
                {
                    textBox1.Text=sqlReader["name"].ToString();
                    textBox2.Text = sqlReader["fname"].ToString();
                    textBox3.Text = logIn.username;

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
