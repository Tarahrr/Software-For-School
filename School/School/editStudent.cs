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
    public partial class editStudent : Form
    {
        public editStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       //     editFormStudent form = new editFormStudent();
            //form.NameTB.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            //form.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image" + dataGridView1.SelectedRows[0].Cells["picture"].Value.ToString());
          //  form.Show();


        }

        private void sea_Click(object sender, EventArgs e)
        {
            //studentTBLTableAdapter.FillByData(dataSet1.StudentTBL, codeMeliTB.Text, NameTB.Text, FamilyTB.Text, codepostiTB.Text, shenasnameTB.Text);
        }

        private void editStudent_Activated(object sender, EventArgs e)
        {
           // studentTBLTableAdapter.Fill(dataSet1.StudentTBL);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //editStudentForm form = new editStudentForm();
           // form.ShowDialog();
        }
        private bool load_tuple()
        {
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" + CodeMeliTB.Text + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private void editStudent_Load(object sender, EventArgs e)
        {
            CodeMeliTB.Text = logIn.username;
            load_tuple();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentTBLTableAdapter1.UpdateQuery1(NameTB.Text, LastNameTB.Text, AddressTB.Text, PostCodeTB.Text, BDateTB.Text, telephoneTB.Text,
                                                FatherNameTB.Text, ClassNoTB.Text, ShenasnameTB.Text, CodeMeliTB.Text);
                MessageBox.Show("ویرایش انجام شد");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
