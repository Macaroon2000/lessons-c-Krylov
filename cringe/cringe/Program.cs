using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cringe
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Расчет индекса массы политоты");

            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш уровень удовлетворения жизнью от 1 до 10:");
            int opinion0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш уровень удовлетворения людьми с именем Володя от 1 до 10:");
            int opinion1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш уровень удовлетворения городом вашего проживания от 1 до 10:");
            int opinion2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш уровень удовлетворения вашим финансовым положением от 1 до 10:");
            int opinion3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш уровень удовлетворения в личной жизни от 1 до 10:");
            int opinion4 = Convert.ToInt32(Console.ReadLine());

            double I = (opinion0 + opinion1 + opinion2 + opinion3 + opinion4);

            {


                if (I > 40)
                {
                    Console.WriteLine($"{name} Аполитичен");

                }
                else if (I > 20)
                {
                    Console.WriteLine($"{name} Взволнован");


                }
                else if (I < 20)
                    Console.WriteLine($"{name} Виновен");

                {
                    Console.ReadLine();


                }

            }
        }

    

