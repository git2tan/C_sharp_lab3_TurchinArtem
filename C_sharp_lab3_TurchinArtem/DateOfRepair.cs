﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab3_TurchinArtem
{
    public class DateOfRepair
    {
        private DateTime date;  //хранит в себе дату
        private string works;   //работы
        private int cost;       //и стоимость этих работ
        //Конструкторы
        public DateOfRepair(DateTime dateOfRepair, string works, int cost)
        {
            this.date = dateOfRepair;
            this.works = works;
            this.cost = cost;
        }
        //свойства
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        public string Works
        {
            set { works = value; }
            get { return works; }
        }
        public int Cost
        {
            set { cost = value; }
            get { return cost; }
        }
        //перегруженный метод ToString()
        public override string ToString()
        {
            string tmpString = String.Format("{0} [{1}],[Стоимость ремонта: {2:N2} руб]", date, works, cost);
            return tmpString;
        }
    }
}
