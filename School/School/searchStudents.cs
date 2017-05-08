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
    public partial class searchStudents : Form
    {
        public searchStudents()
        {
            InitializeComponent();
        }

        private void sea_Click(object sender, EventArgs e)
        {
            studentTBLTableAdapter.FillByData(dataSet1.StudentTBL, codeMeliTB.Text, NameTB.Text, FamilyTB.Text,codepostiTB.Text, shenasnameTB.Text);
        }

        private void searchStudents_Load(object sender, EventArgs e)
        {
          //  this.studentTBLTableAdapter.Fill(this.dataSet1.StudentTBL);
        }
    }
}
