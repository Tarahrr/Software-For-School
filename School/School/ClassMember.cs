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
    public partial class ClassMember : Form
    {
        public ClassMember()
        {
            InitializeComponent();
        }

        private void ClassMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ClassMemeber' table. You can move, or remove it, as needed.
            //this.classMemeberTableAdapter.Fill(this.dataSet1.ClassMemeber);
            // TODO: This line of code loads data into the 'dataSet1.Class' table. You can move, or remove it, as needed.
            //this.classTableAdapter.Fill(this.dataSet1.Class);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classMemeberTableAdapter.FillByid(dataSet1.ClassMemeber, textBox1.Text);
        }
    }
}
