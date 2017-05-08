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
    public partial class lessonChoose : Form
    {
        public lessonChoose()
        {
            InitializeComponent();
        }

        private void lessonChoose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EXAMLESSON' table. You can move, or remove it, as needed.
            this.eXAMLESSONTableAdapter.Fill(this.dataSet1.EXAMLESSON);
            // TODO: This line of code loads data into the 'dataSet1.STDLESSON' table. You can move, or remove it, as needed.
         //   this.sTDLESSONTableAdapter.Fill(this.dataSet1.STDLESSON);
            textBox1.Text=logIn.username; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                weight += Convert.ToInt16(dataGridView1.Rows[i].Cells[1].Value.ToString());
            if (weight + Convert.ToInt16(textBox3.Text) <= 18)
                sTDLESSONTableAdapter.Insert(textBox1.Text + textBox2.Text, Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox2.Text),textBox1.Text);
            else
                MessageBox.Show("قادر به انتخاب این درس نمی باشید بیش از حد مجاز واحد برداشته اید");

            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int weight = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                weight += Convert.ToInt16(dataGridView1.Rows[i].Cells[1].Value.ToString());
            textBox5.Text = weight.ToString();
            sTDLESSONTableAdapter.DeleteQuery1(textBox1.Text + textBox2.Text);
            dataGridView1.Refresh();
        }
    }
}
