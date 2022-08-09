//������ �����


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
                    Console.WriteLine("������, ��������� �������� �� �������� ������.");
                else return x;
        }


        static void Main(string[] args)
        {
            //1. �) �������� ��������� Complex, ������� ����� ��������� ����������� �����.
            //������������������ ������ ���������.
            //�) �������� ����� Complex, ������� ������ ��������� � ������������ �����. ��������� ������ ������.
            //�) �������� ������ � �������������� switch ��������������� ������ ������.

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("��������� ��������: " + result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine("��������� ���������: " + result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine("��������� ���������: " + result.ToString());

            Console.WriteLine("");
            Console.Write("��� ����������� ������� Enter");
            Console.ReadKey();




            //2. �) � ���������� �������� �����, ���� �� ����� ����� 0 (������ ����� � ����� ������).
            //��������� ���������� ����� ���� �������� ������������� �����. ���� ����� � �����
            //������� �� �����, ��������� tryParse.

            Console.WriteLine("��������� �������� ����� �������� ������������� �����" + Environment.NewLine + "������� �� ������ �����:");

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

            Console.WriteLine("�������� ������������� �����:");
            foreach (int item in odd_num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("�����: " + cumulative);

            Console.WriteLine("");
            Console.Write("��� ���������� ������� Enter");
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