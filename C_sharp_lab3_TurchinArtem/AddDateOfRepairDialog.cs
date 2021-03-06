﻿using System;
using System.Windows.Forms;

namespace C_sharp_lab3_TurchinArtem
{
    public partial class AddDateOfRepairDialog : Form
    {
        public AddDateOfRepairDialog()
        {
            InitializeComponent();
        }

        public DateTime Date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public int Cost
        {
            get { return int.Parse(textCost.Text); }
            set { textCost.Text = value.ToString(); }
        }
        public string Work
        {
            get { return richTextRepair.Text; }
            set { richTextRepair.Text = value.ToString(); }
        }
    }
}
