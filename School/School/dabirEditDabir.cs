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
    public partial class dabirEditDabir : Form
    {
        public dabirEditDabir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dabirTableAdapter.UpdateQuery1(shenasnameTB.Text, NameTB.Text, LastNameTB.Text, addressTB.Text, PostCodeTB.Text, TelephoneTB.Text,
                                                    BdateTB.Text, TahsilatTB.Text, MobileTB.Text, CodeMeliTB.Text);
                MessageBox.Show("ویرایش انجام شد");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Dabir WHERE ssn='" + logIn.username + "'";
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

        private void dabirEditDabir_Load(object sender, EventArgs e)
        {
            CodeMeliTB.Text = logIn.username;
            load_tuple();
        }
    }
}
