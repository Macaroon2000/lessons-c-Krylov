using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {
        static string hello="Привет";
        static void Pause()
        {
            Console.ReadKey();
        }
        static double Calc(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("Расчет индекса массы тела");

            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваше фамилию:");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост:");
            double height  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{hello}, {name}!\nФИО:\t{fio}\nЛет:\t{age}\nРост:\t{height}\nВес:\t{weight}");
            // задание 2
            double I = weight/(height*height);
            Console.WriteLine($"Ваш индекс массы: {I}");
            // задание 3
            Console.WriteLine("расчет расстояния между точками");
            Console.WriteLine("x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Calc(x1,x2, y1, y2);
            Console.WriteLine($"Расстояние между точками: {r}");

            Pause();
            
        }
    }
}
