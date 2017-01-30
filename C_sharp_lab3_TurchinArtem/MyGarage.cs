using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_sharp_lab3_TurchinArtem
{
    public partial class MyGarage : Form
    {
        List<CargoCar> myListOfCar = new List<CargoCar>();
        

        public MyGarage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDialogForm dlg = new AddDialogForm();
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                CargoCar tmpCargoCar = new CargoCar((Marks)dlg.Marka, dlg.Power, dlg.Price, dlg.MaxCargoWeight);
                myListOfCar.Add(tmpCargoCar);
            }
            refreshListBoxOfCar();
            refreshListOfRepair();
        }

        private void MyGarage_Load_1(object sender, EventArgs e)
        {
            //CargoCar firstCar = new CargoCar(Marks.toyota, 150, 400000, 0.4);
            //myListOfCar.Add(firstCar);
            //firstCar.RepairNow("Что-то", 10000);
            refreshListBoxOfCar();
            //listBox1.SelectedIndex = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Не выбрана машина!", "Ошибка выбора", MessageBoxButtons.OK);
            }
            else
            {
                myListOfCar.RemoveAt(listBox1.SelectedIndex);
                
                refreshListBoxOfCar();
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            if(checkBox1.Checked)
            {
                refreshListOfRepair();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;             //запомнил индекс который выбрал в списке
            CargoCar tmpCar = myListOfCar[i];           // создал ссылку и направил ее на объект из списка в соотв.с индексом
            EditFormDialog editDlg = new EditFormDialog();//создал объект подчиненной формы
            //провожу инициализацию полей формы до того как вывести ее на экран
            editDlg.Number = i; //у подч формы есть поле-свойство Number ему передал индекс
            editDlg.Marka = (int)tmpCar.Marka;  //это марка авто
            editDlg.MaxCargo = tmpCar.MaxCargoWeight;   //это грузоподъемн
            editDlg.Price = tmpCar.Price;
            editDlg.Power = tmpCar.Power;
            editDlg.ListOfRepair = tmpCar.ListOfRepairsDate;    //устанавливаю ссылку на список
            editDlg.ShowDialog();   //вывожу форму
            if (editDlg.DialogResult==DialogResult.OK)
            {
                tmpCar.Marka = (Marks)editDlg.Marka;
                tmpCar.Price = editDlg.Price;
                tmpCar.Power = editDlg.Power;
                tmpCar.MaxCargoWeight = editDlg.MaxCargo;
                tmpCar.ListOfRepairsDate = editDlg.ListOfRepair;
            }
            else
            {

            }
            refreshListBoxOfCar();
            refreshListOfRepair();
        }
        private void refreshListBoxOfCar()
        {
            listBox1.Items.Clear();
            if (myListOfCar.Count>0)
            {
                foreach (CargoCar eachCargoCar in myListOfCar)
                {
                    listBox1.Items.Add(eachCargoCar.ToStringWithoutRepDates());
                }
            }
            else
            {
                
            }
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void refreshListOfRepair()
        {
            listOfRepairs.Items.Clear();
            if (listBox1.SelectedIndex!=-1)
            {
                if(myListOfCar[listBox1.SelectedIndex].ListOfRepairsDate.Count>0)
                    foreach(DateOfRepair each in myListOfCar[listBox1.SelectedIndex].ListOfRepairsDate)
                    {
                        listOfRepairs.Items.Add(each.ToString());
                    }
                else
                    listOfRepairs.Items.Add("Ремонты не производились");
            }
            else
            {
                listOfRepairs.Items.Add("Выберите авто для отображения списка ремонтов");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listOfRepairs.Visible = true;
                if (listBox1.SelectedIndex != -1)
                {
                    refreshListOfRepair();
                }
                repairsToolStripMenuItem.Checked = true;
            }
            else
            {
                listOfRepairs.Visible = false;
                repairsToolStripMenuItem.Checked = false;
            }
        }

        private void repairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repairsToolStripMenuItem.Checked)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
