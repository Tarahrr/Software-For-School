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
    public partial class namayeshDorous : Form
    {
        public namayeshDorous()
        {
            InitializeComponent();
        }

        private void namayeshDorous_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LessonGroupLesson' table. You can move, or remove it, as needed.
            this.lessonGroupLessonTableAdapter.Fill(this.dataSet1.LessonGroupLesson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // lessonGroupLessonTableAdapter.FillBy(dataSet1.LessonGroupLesson, textBox4.Text, textBox2.Text, Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox1.Text));

        }
    }
}
