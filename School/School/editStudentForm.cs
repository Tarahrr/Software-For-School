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
    public partial class editStudentForm : Form
    {
        public editStudentForm()
        {
            InitializeComponent();
        }

        private void StudentEditStundent_Load(object sender, EventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentTBLTableAdapter1.UpdateQuery1(NameTB.Text, LastNameTB.Text, AddressTB.Text, PostCodeTB.Text,
                                                   BDateTB.Text, telephoneTB.Text, FatherNameTB.Text, ClassNoTB.Text, ShenasnameTB.Text, CodeMeliTB.Text);
                MessageBox.Show("ویرایش شد");
                NameTB.Text = "" ;
                LastNameTB.Text= "" ;
                AddressTB.Text= "" ; 
                PostCodeTB.Text= "" ;
                BDateTB.Text= "" ;
                telephoneTB.Text= "" ;
                FatherNameTB.Text= "" ;
                ClassNoTB.Text= "" ;
                ShenasnameTB.Text = ""; 
                CodeMeliTB.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool load_tuple(){
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {
               
                string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" +CodeMeliTB.Text  + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();
                if (sqlReader.Read())
                {
                    
                    NameTB.Text = sqlReader["name"].ToString();
                    LastNameTB.Text = sqlReader["fname"].ToString();
                    AddressTB.Text = sqlReader["address"].ToString();
               
                    PostCodeTB.Text = sqlReader["postalcode"].ToString();
                    FatherNameTB.Text = sqlReader["fatherName"].ToString();
                    ClassNoTB.Text = sqlReader["classNo"].ToString();
                    ShenasnameTB.Text = sqlReader["shenasname"].ToString();
                    telephoneTB.Text = sqlReader["phone"].ToString();
                    BDateTB.Text = sqlReader["Bdate"].ToString();
                }
                sqlReader.Close();
            }
            catch(Exception ex)
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

        private void NameTB_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
