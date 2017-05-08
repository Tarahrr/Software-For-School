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
    public partial class namayeshMeeting : Form
    {
        public namayeshMeeting()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void namayeshMeeting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MeeyingDabir' table. You can move, or remove it, as needed.
          //  this.meeyingDabirTableAdapter.Fill(this.dataSet1.MeeyingDabir);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meeyingDabirTableAdapter.FillBy(dataSet1.MeeyingDabir, textBox1.Text, logIn.username);
        }
    }
}
