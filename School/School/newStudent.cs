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
    public partial class newStudent : Form
    {
        String filename;
        String saveFileName;
        public newStudent()
        {
            InitializeComponent();
        }

        private void pictureBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {

            //studentTBLTableAdapter1.Insert(ssnTB.Text, nameTB.Text, lastnameTB.Text, shenasnameTB.Text, addressTB.Text, emailTB.Text, postalcodeTB.Text,null,phoneTB.Text,fathernameTB.Text,Convert.ToSingle(moadelTB.Text),Convert.ToInt16(payeTB.Text),Convert.ToInt16(classNoTB.Text),null);
        //    studentTBLTableAdapter1.Insert(ssnTB.Text, "h", "h","001", "tehran", "hhh", "gfdgaga", "agag", "afgafg", "gfaga",0,0,0,"trtqt");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void newStudent_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            try
            {
           //      if (openFileDialog1.FileName != null)
             //        System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Image\\" + CodeMeliTB.Text + ".png");
                
                studentTBLTableAdapter1.Insert(CodeMeliTB.Text, NameTB.Text, LastNameTB.Text, AddressTB.Text, emailTB.Text, PostCodeTB.Text, BDateTB.Text, telephoneTB.Text, FatherNameTB.Text, ClassNoTB.Text, CodeMeliTB.Text + ".png", ShenasnameTB.Text);
        
                
                MessageBox.Show("ثبت نام با موفقیت انجام شد");
                
                NameTB.Clear();
                LastNameTB.Clear();
                CodeMeliTB.Clear();
                ShenasnameTB.Clear();
                FatherNameTB.Clear();
                BDateTB.Clear();
                ClassNoTB.Clear();
                emailTB.Clear();
                PostCodeTB.Clear();
                AddressTB.Clear();
                telephoneTB.Clear();
                
               
            }
            catch (Exception ex)
            {

               // MessageBox.Show("در ذخیره ی اطلاعات به مشکل برخورد کردید.لطفا دوباره امتحان کنید", "اخطار");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChoosePicture_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
