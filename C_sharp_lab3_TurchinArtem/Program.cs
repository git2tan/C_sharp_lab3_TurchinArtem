﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_sharp_lab3_TurchinArtem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<CargoCar> myListOfCar = new List<CargoCar>();
            Application.Run(new MyGarage(myListOfCar));
        }
    }
}
