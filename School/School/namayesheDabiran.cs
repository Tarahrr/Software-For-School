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
    public partial class namayesheDabiran : Form
    {
        public namayesheDabiran()
        {
            InitializeComponent();
        }

        private void namayesheDabiran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Dabir' table. You can move, or remove it, as needed.
            this.dabirTableAdapter.Fill(this.dataSet1.Dabir);

        }
    }
}
