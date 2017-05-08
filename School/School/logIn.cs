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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            loadTable.load();
            this.usersTableAdapter.Fill(this.dataSet1.Users);

        }

        private void titleLB_Click(object sender, EventArgs e)
        {

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string username;
        private void enterBTN_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            Boolean check_st = false;
            Boolean check_db = false;
           

            if (usernameTB.Text.ToLower() == "admin" && passTB.Text.ToLower() == "admin")
            {
                errorLB.Text = "";
                this.Hide();
                Admin form = new Admin();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == usernameTB.Text)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == passTB.Text)
                        {

                            check = true;
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "true")
                            {
                                SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                                try
                                {

                                    string Query = "SELECT * FROM StudentTBL WHERE codeMeli='" + usernameTB.Text + "'";
                                    SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                                    sqlcon.Open();

                                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                                    if (sqlReader.Read())
                                    {

                                        username = usernameTB.Text;
                                        StudentMain form = new StudentMain();
                                        // this.Hide();
                                        form.ShowDialog();
                                        check_st = true;
                                        // errorLB.Text = check_st.ToString();
                                        //  this.Close();
                                        break;
                                    }
                                    else
                                    {
                                        errorLB.Text = "نام کاربری یا گذر واژه نا درست است";
                                    }
                                    sqlReader.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                
                                }
                                       
                            }

                            else
                            {
                               SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                                try
                                {

                                    string Query = "SELECT * FROM Dabir WHERE ssn='" + usernameTB.Text + "'";
                                    SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                                    sqlcon.Open();

                                    SqlDataReader sqlReader = sqlcom.ExecuteReader();
                                    if (sqlReader.Read())
                                    {
                                        username = usernameTB.Text;
                                       DabirMenu form = new DabirMenu();
                                        this.Hide();
                                       form.ShowDialog();
                                        check_db = true;
                                        this.Close();
                                        break;
                                    }
                                    else
                                    {
                                        errorLB.Text = "نام کاربری یا گذر واژه نا درست است";
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


                if (check == false)
                    errorLB.Text = "نام کاربری یا گذر واژه نا درست است";
                     
            }    
        }

        private void newUserLB_Click(object sender, EventArgs e)
        {

        }

        private void passTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passLB_Click(object sender, EventArgs e)
        {

        }

        private void usernameLB_Click(object sender, EventArgs e)
        {

        }

        private void errorLB_Click(object sender, EventArgs e)
        {

        }

        private void usernameTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterBTN.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            saveData.saveSTD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData.save();
        }
    }
}
