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
    public partial class namayeshparents : Form
    {
        public namayeshparents()
        {
            InitializeComponent();
        }

        private void namayeshparents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentParents' table. You can move, or remove it, as needed.
          //  this.studentParentsTableAdapter.Fill(this.dataSet1.StudentParents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentParentsTableAdapter.FillBydata(dataSet1.StudentParents, textBox2.Text, textBox3.Text, textBox1.Text);
        }
    }
}
