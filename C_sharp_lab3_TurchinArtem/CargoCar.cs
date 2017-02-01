using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab3_TurchinArtem
{
    public class CargoCar : Car          //создаем класс-наследник грузовой авто
    {
        private double maxCargoWeight;  //у грузового авто имеется характеристика г.п.

        public double MaxCargoWeight    //свойство для поля maxCargoWeight
        {
            set { maxCargoWeight = value; }
            get { return maxCargoWeight; }
        }

        public CargoCar() : base(Marks.mitsubishi, 120, 600000)    //конструктор по умолчанию
        {
            this.maxCargoWeight = 3.2;
        }
        public CargoCar(Marks marka, int power, double price, double maxCargoWeight) : base(marka, power, price)    //конструктор с параметрами
        {
            this.maxCargoWeight = maxCargoWeight;
        }
        public override string ToString()   //перегруженный метод родительского класса
        {
            string s = String.Format("[марка: {0}], [мощность: {1}л.с,г.п.: {3}т], [цена: {2:N} руб].\nДаты ремонта:", this.Marka, this.Power, this.Price, maxCargoWeight);

            if (this.ListOfRepairsDate.Count > 0)
            {
                int indx = 0;
                foreach (var each in this.ListOfRepairsDate)
                {
                    s += "\n" + "[" + indx + "]";
                    s += each.ToString();
                    indx++;
                }
            }
            else
            {
                s += "не ремонтировалась";
            }
            return s;
        }
        
        public override double Acceleration()
        {
            return 1 / (maxCargoWeight + 0.5) * 1000 / Power;
        }
        public override void DriveOneMile(Car car)
        {
            double one, two;
            one = this.Acceleration();
            two = car.Acceleration();
            if (this.Acceleration() > car.Acceleration())
                Console.WriteLine("Победитель заезда на 1 милю - {0}, проиграл - {1}", this.Marka, car.Marka);
            else if (this.Acceleration() < car.Acceleration())
                Console.WriteLine("Победитель заезда на 1 милю - {1}, проиграл - {0}", this.Marka, car.Marka);
            else
                Console.WriteLine("Машины приехали одновременно!!!");
        }
        public override string ToStringWithoutRepDates()
        {
            return base.ToStringWithoutRepDates()+", [г.п. "+maxCargoWeight+"т.]";
        }
    }
}
