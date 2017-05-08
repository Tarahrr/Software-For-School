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
    public partial class ShowLessonDabir : Form
    {
        public ShowLessonDabir()
        {
            InitializeComponent();
        }

        private void ShowLessonDabir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DabirLessonShow' table. You can move, or remove it, as needed.
            textBox1.Text = logIn.username;
            this.dabirLessonShowTableAdapter.FillBy(this.dataSet1.DabirLessonShow,textBox1.Text);

        }
    }
}
