﻿using System;
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
    public partial class namayesheExams : Form
    {
        public namayesheExams()
        {
            InitializeComponent();
        }

        private void namayesheExams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.dataSet1.exam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            examTableAdapter.FillBydata(dataSet1.exam, Convert.ToInt16(textBox1.Text));

        }
    }
}
