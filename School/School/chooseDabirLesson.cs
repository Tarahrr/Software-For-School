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
    public partial class chooseDabirLesson : Form
    {
        public chooseDabirLesson()
        {
            InitializeComponent();
        }

        private void chooseDabirLesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DabirLesson' table. You can move, or remove it, as needed.
            this.dabirLessonTableAdapter.Fill(this.dataSet1.DabirLesson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dabirLessonTableAdapter.Insert(textBox1.Text + textBox2.Text, textBox1.Text, Convert.ToInt16(textBox2.Text));
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dabirLessonTableAdapter.UpdateQuery1(textBox1.Text + textBox2.Text, textBox1.Text, Convert.ToInt16(textBox2.Text), textBox1.Text + textBox2.Text);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dabirLessonTableAdapter.DeleteQuery1(textBox1.Text + textBox2.Text);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
