//Крылов Роман


using System;
using System.Collections.Generic;

namespace Lesson_3
{
    class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.WriteLine("Ошибка, введенное значение не является числом.");
                else return x;
        }


        static void Main(string[] args)
        {
            //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
            //Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения: " + result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания: " + result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine("Результат умножения: " + result.ToString());

            Console.WriteLine("");
            Console.Write("Для продолжения нажмите Enter");
            Console.ReadKey();




            //2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
            //вывести на экран, используя tryParse.

            Console.WriteLine("Программа подсчета суммы нечетных положительных чисел" + Environment.NewLine + "Введите по одному числу:");

            int i = 0;
            int cumulative = 0;
            List<int> odd_num = new List<int>();

            do
            {
                //int i = Convert.ToInt32(Console.ReadLine());
                bool flag = int.TryParse(Console.ReadLine(), out i);

                if (i % 2 != 0 && i > 0)
                {
                    odd_num.Add(i);
                    cumulative += i;
                }
            } while (i != 0);

            Console.WriteLine("Нечетные положительные числа:");
            foreach (int item in odd_num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Сумма: " + cumulative);

            Console.WriteLine("");
            Console.Write("Для завершения нажмите Enter");
            Console.ReadKey();
        }
    }

    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}