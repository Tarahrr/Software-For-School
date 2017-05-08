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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void exitLB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void registerStudentLB_Click(object sender, EventArgs e)
        {
            newStudent form = new newStudent();
            form.ShowDialog();
        }

        private void manageStudentLB_Click(object sender, EventArgs e)
        {
            editStudent form = new editStudent();
            form.ShowDialog();
        }

        private void weekStudentsLB_Click(object sender, EventArgs e)
        {
            newGroupDarCi form = new newGroupDarCi();
            form.ShowDialog();
        }

        private void registerTeacherLB_Click(object sender, EventArgs e)
        {
            newTeacher form = new newTeacher();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            editTeacher form = new editTeacher();
            form.ShowDialog();
        }

        private void weekTeacherLB_Click(object sender, EventArgs e)
        {
            namayeshDorous form = new namayeshDorous();
            form.ShowDialog();
        }

        private void lessonTeacherLB_Click(object sender, EventArgs e)
        {
          //  lessonTeacher form = new lessonTeacher();
           // form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ClassMember form = new ClassMember();
            form.ShowDialog();
        }

        private void weekClass_Click(object sender, EventArgs e)
        {
            newLesson form = new newLesson();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            changePassAdmin form = new changePassAdmin();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            newUser form = new newUser();
            form.ShowDialog();
        }

        private void exitLB_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void omoreMaliTeacherLB_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
            namayeshDaneshAmuz form = new namayeshDaneshAmuz();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            namayesheDabiran form = new namayesheDabiran();
            form.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            searchStudents form = new searchStudents();
            form.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DeleteStudent form = new DeleteStudent();
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            editStudentForm form = new editStudentForm();
          // editStudent form = new editStudent();
            form.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            searchTeacher form = new searchTeacher();
            form.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DeleteDabir form = new DeleteDabir();
            form.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            saveData.save();
            logIn form = new logIn();
            this.Hide();
            this.Close();
            
            form.ShowDialog();
           
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.ShowDialog();
        }

        private void helpLB_Click(object sender, EventArgs e)
        {
            helpform form = new helpform();
            form.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            newClass form = new newClass();
            form.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            newGroupDarCi form = new newGroupDarCi();
            form.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            newLesson form = new newLesson();
            form.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            namayeshDorous form = new namayeshDorous();
            form.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            newParents form = new newParents();
            form.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            editParents form = new editParents();
            form.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            namayeshparents form = new namayeshparents();
            form.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            chooseDabirLesson form = new chooseDabirLesson();
            form.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            newExam form = new newExam();
            form.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {
          //  showExam form = new showExam();
          //  form.ShowDialog();
        }

        private void label23_Click_1(object sender, EventArgs e)
        {
            namayesheExams form = new namayesheExams();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData.save();
        }
    }
}
