using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Speed : Bus
    {
        string Name;
        double s;
        public Speed() : base()
        {
            Name = null;
            Input();
        }
        public void Input()
        {
            Console.Write("Введите марку автобуса: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите скорость автобуса");
            s = Convert.ToDouble(Console.ReadLine());
        }


        public override void IncomePay()
        {
            Income = Price * Count * (s * K);
        }
        public void GetInfo()
        {
            Console.WriteLine("Количество пассажиров:{0} \nСтоимость билета:{1} \nПовышающий коэффициент:{2} \nМарка автобуса:{3} \nОбщая стоимость всех мест: {4} \nСкорость: {5} км/ч", Count, Price, K, Name, Income, s);
        }
    }
}