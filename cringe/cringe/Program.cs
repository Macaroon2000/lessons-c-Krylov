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
                // задание 1
                Console.WriteLine("Расчет индекса массы политоты");

                Console.WriteLine("Введите ваше имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите ваш уровень удовлетворения жизнью:");
                byte lsl = Convert.ToInt8(Console.ReadLine());
            Console.WriteLine("Введите ваш возраст:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ваш рост:");
                double height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ваш вес:");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"={name}\nФИО:\t{lsl}\nЛет:\t{age}\nРост:\t{height}\nВес:\t{weight}");
            }
    }
}
