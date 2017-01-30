using System;
using System.Windows.Forms;

namespace C_sharp_lab3_TurchinArtem
{
    public partial class AddDialogForm : Form
    {
        public AddDialogForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 5;
        }
        
        public int Marka
        {
            get { return comboBox1.SelectedIndex; }
            
        }

        public int Power
        {
            get { return int.Parse(textPower.Text);  }
            set { textPower.Text = value.ToString(); }
        }
        public double Price
        {
            get { return double.Parse(textPrice.Text); }
            set { textPrice.Text = value.ToString(); }
        }
        public double MaxCargoWeight
        {
            get { return double.Parse(textCargoWeight.Text); }
            set { textCargoWeight.Text = value.ToString(); }
        }
    }
}
