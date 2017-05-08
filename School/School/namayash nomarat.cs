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
    public partial class namayash_nomarat : Form
    {
        public namayash_nomarat()
        {
            InitializeComponent();
        }

        private void namayash_nomarat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentPoint' table. You can move, or remove it, as needed.
         //   this.studentPointTableAdapter.Fill(this.dataSet1.StudentPoint);
            // TODO: This line of code loads data into the 'dataSet1.point' table. You can move, or remove it, as needed.
         //   this.pointTableAdapter.Fill(this.dataSet1.point);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentPointTableAdapter.FillBydata(dataSet1.StudentPoint, Convert.ToInt16(textBox2.Text), textBox3.Text, Convert.ToInt16(textBox1.Text), textBox4.Text);
        }
    }
}
