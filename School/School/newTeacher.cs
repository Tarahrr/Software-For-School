using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class newTeacher : Form
    {
        String filename;
        String saveFileName;
        public newTeacher()
        {
            InitializeComponent();
        }

        private void pictureBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void shomareDarsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void shomareDarsLB_Click(object sender, EventArgs e)
        {

        }

        private void shomarehesabTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void shomarehesabLB_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEstekhdam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void estekhdamLB_Click(object sender, EventArgs e)
        {

        }

        private void gharadadNoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void gharadadNoLB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureLB_Click(object sender, EventArgs e)
        {

        }

        private void registerBTN_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobileTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssnTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BdateLB_Click(object sender, EventArgs e)
        {

        }

        private void addressLB_Click(object sender, EventArgs e)
        {

        }

        private void emailLB_Click(object sender, EventArgs e)
        {

        }

        private void mobileLB_Click(object sender, EventArgs e)
        {

        }

        private void ssnLB_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLB_Click(object sender, EventArgs e)
        {

        }

        private void nameLB_Click(object sender, EventArgs e)
        {

        }

        private void titleLB_Click(object sender, EventArgs e)
        {

        }

        private void newTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Dabir' table. You can move, or remove it, as needed.
            this.dabirTableAdapter.Fill(this.dataSet1.Dabir);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                    filename = dlg.FileName;
                    saveFileName = dlg.SafeFileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
             {

                // System.IO.File.Copy(filename, Application.StartupPath + "\\DabirImage\\" +CodeMeliTB.Text+".png");
                dabirTableAdapter.Insert(CodeMeliTB.Text, shenasnameTB.Text, NameTB.Text, LastNameTB.Text, addressTB.Text, PostCodeTB.Text, emailTB.Text, TelephoneTB.Text, BdateTB.Text, TahsilatTB.Text, MobileTB.Text, CodeMeliTB.Text+".png");
                  MessageBox.Show("ثبت نام با موفقیت انجام شد");
                CodeMeliTB.Text="";
                shenasnameTB.Text=""; 
                NameTB.Text="";
                LastNameTB.Text="";
                addressTB.Text="";
                PostCodeTB.Text=""; 
                emailTB.Text=""; 
                TelephoneTB.Text="";
                BdateTB.Text="";
                TahsilatTB.Text="";
                MobileTB.Text = "";


             }
            catch (Exception ex)
            {
                MessageBox.Show("در ذخیره ی اطلاعات به مشکل برخورد کردید.لطفا دوباره امتحان کنید", "اخطار");
            }
        }
    }
}
