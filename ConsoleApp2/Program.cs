using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quontity = 100000000; // кол-во населения
            double area = 60000; //площадь территории
            double density = Math.Round(quontity / area, 2); //формула для вычисления плотности
            Console.WriteLine("Плотность населения ДНР равна {0} чел/км", density); //вывод плотности населения
            Console.WriteLine(new string('-', 50));
        }
    }
}
