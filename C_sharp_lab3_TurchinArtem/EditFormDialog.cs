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
    public partial class EditFormDialog : Form
    {
        public List<DateOfRepair> listOfRepair;
        private List<DateOfRepair> tmpListOfRepair = new List<DateOfRepair>();
        public EditFormDialog()
        {
            InitializeComponent();
        }
       
        public int Number
        {
            set { labelOfNumber.Text = value.ToString(); }
        }

        public int Marka
        {
            set { comboBoxOfMarks.SelectedIndex = value; }
            get { return comboBoxOfMarks.SelectedIndex; }
        }

        public double Price
        {
            set { textPrice.Text = value.ToString(); }
            get { return double.Parse(textPrice.Text); }
        }

        public int Power
        {
            set { textPower.Text = value.ToString(); }
            get { return int.Parse(textPower.Text); }
        }

        public double MaxCargo
        {
            set { textCargo.Text = value.ToString(); }
            get { return double.Parse(textCargo.Text); }
        }

        public List<DateOfRepair> ListOfRepair
        {
            set { listOfRepair = value; }
            get { return listOfRepair; }
        }

        private void EditFormDialog_Load(object sender, EventArgs e)
        {
            
            tmpListOfRepair.AddRange(listOfRepair);
            refreshListBox();
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            AddDateOfRepairDialog addRepair = new AddDateOfRepairDialog();
            addRepair.Date = DateTime.Now;
            addRepair.Cost = 700;
            addRepair.Work = "Диагностика";
            addRepair.ShowDialog();
            if(addRepair.DialogResult==DialogResult.OK)
            {
                tmpListOfRepair.Add(new DateOfRepair(addRepair.Date, addRepair.Work, addRepair.Cost));
            }
            else
            {

            }
            refreshListBox();
        }
        private void refreshListBox()
        {
            listBoxOfRepairs.Items.Clear();
            if(tmpListOfRepair.Count>0)
            {
                foreach (DateOfRepair each in tmpListOfRepair)
                {
                    listBoxOfRepairs.Items.Add(each.ToString());
                }
            }
            else
            {
                listBoxOfRepairs.Items.Add("Ремонтов не проводилось");
            }
            
            btnDel.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            listOfRepair = tmpListOfRepair;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tmpListOfRepair.RemoveAt(listBoxOfRepairs.SelectedIndex);
            refreshListBox();            
        }

        private void listBoxOfRepairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
        }
    }
}
