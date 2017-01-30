using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_lab3_TurchinArtem
{
    public partial class AddDialogForm : Form
    {
        //Marks marka;
        public AddDialogForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 5;
        }
        
        public int Marka
        {
            get {
                //Marks newMarka;
                //newMarka = (Marks)(int.Parse(textMarka.Text));
                //return newMarka;
                //return int.Parse(textMarka.Text);
                return comboBox1.SelectedIndex;
            }
            //set { textMarka.Text = value.ToString(); }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
