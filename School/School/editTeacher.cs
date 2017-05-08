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
    public partial class editTeacher : Form
    {
        public editTeacher()
        {
            InitializeComponent();
        }

        private void pictureBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //   editTeacherForm form = new editTeacherForm();
           //form.NameTB.Text = dataGridView1.Rows[0].Cells["name"].Value.ToString();
            //form.NameTB.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            //form.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image" + dataGridView1.SelectedRows[0].Cells["picture"].Value.ToString());
            //form.Show();
        }

        private void sea_Click(object sender, EventArgs e)
        {
            
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Dabir WHERE ssn='" + CodeMeliTB.Text + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {

                    NameTB.Text = sqlReader["name"].ToString();
                    LastNameTB.Text = sqlReader["fname"].ToString();
                    addressTB.Text = sqlReader["address"].ToString();
                    PostCodeTB.Text = sqlReader["postalcode"].ToString();
                    shenasnameTB.Text = sqlReader["shenasname"].ToString();
                    TelephoneTB.Text = sqlReader["phone"].ToString();
                    BdateTB.Text = sqlReader["Bdate"].ToString();
                    TahsilatTB.Text = sqlReader["tahsilat"].ToString();
                    MobileTB.Text = sqlReader["mobile"].ToString();
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
        private void CodeMeliTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                load_tuple();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dabirTableAdapter.UpdateQuery1(shenasnameTB.Text, NameTB.Text, LastNameTB.Text, addressTB.Text, PostCodeTB.Text, TelephoneTB.Text,
                                                BdateTB.Text, TahsilatTB.Text, MobileTB.Text, CodeMeliTB.Text);
                MessageBox.Show("ویرایش شد");
                CodeMeliTB.Text = "";
                NameTB.Text = "";
                LastNameTB.Text = "";
                addressTB.Text = "";
                PostCodeTB.Text = "";
                shenasnameTB.Text = "";
                TelephoneTB.Text = "";
                BdateTB.Text = "";
                TahsilatTB.Text = "";
                MobileTB.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CodeMeliTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
