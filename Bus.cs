using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Bus
    {
        private double count;
        private double price;
        private double income;
        private double k;
        public Bus()
        {
            count = 0;
            price = 0;
            income = 0;
            k = 0;
            Input();
        }

        public virtual void IncomePay()
        {
            income = k * price;
        }
        public double Count { get { return count; } set { count = value; } }
        public double Price { get { return price; } set { price = value; } }
        public double K { get { return k; } set { k = value; } }
        public double Income { get { return income; } set { income = value; } }
        public void Input()
        {
            Console.Write("Ввeдите количество пассажиров: ");
            count = Convert.ToDouble(Console.ReadLine());
            Console.Write("Стоимость билета: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите повышающий коэффициент: ");
            k = Convert.ToDouble(Console.ReadLine());
        }
    }
}