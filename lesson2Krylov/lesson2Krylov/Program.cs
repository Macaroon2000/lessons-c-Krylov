using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Крылов Роман
namespace lesson2Krylov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine("Определение минимального из трех целых чисел");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = 0;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine("Наименьшее число {0}", min);

            Console.WriteLine("");
            Console.ReadKey();
            //2. Написать метод подсчета количества цифр




            Console.Write("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Количество цифр в числе:  {0}", count);

            Console.ReadKey();
            /*3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
            {
                Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                int i, sum = 0;
                Console.WriteLine("Введите числа, нажимая после каждого Enter.");
                do
                {
                    i = int.Parse(Console.ReadLine());
                    if ((i % 2 == 1) && (i > 0)) sum += i;
                } while (i != 0);
                Console.WriteLine("Результат: {0}\n---", sum);
                //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
                //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
                //Используя метод проверки логина и пароля, написать программу:
                //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
                //С помощью цикла do while ограничить ввод пароля тремя попытками.


                Console.WriteLine("Проверка логина и пароля");
                int AmountOfTries = 3;

                do
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();

                    if (login == "root" && password == "GeekBrains")
                    {
                        Console.WriteLine("Авторизация успешна!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод логина или пароля." +
                        Environment.NewLine + "У Вас осталось попыток: " + --AmountOfTries);
                    }

                } while (AmountOfTries > 0);


                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
