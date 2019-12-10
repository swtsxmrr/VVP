using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_10__1_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ===============================

            /*
            double C,v;
            Console.Write("Введите цену за 1 кг конфет (руб.): ");
            C = float.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                v = C*(0.1 * i);
                Console.WriteLine("Стоимость за " + (0.1*i) + " кг: " + v + " ");
            }
            Console.ReadKey();
            */

            //Задание 2 ===============================

            /*
            double P, C;
            int N;
            Console.Write("Введите число: ");
            N = int.Parse(Console.ReadLine());
            P = C = 1;
            while (N != 0)
            {
                P = C * P;
                C = C + 0.1;
                N = N - 1;
            }
            Console.WriteLine("Произведение: " + P);
            Console.ReadKey();
            */

            //Задание 3 ===============================

            /*
            int N, N1, P;
            Console.Write("Введите число: ");
            N = int.Parse(Console.ReadLine());
            N1 = N * 2 - 1;
            P = 0;
            while (N1 > 0)
            {
                P = P + N1;
                Console.Write(P + " ");
                N1 = N1 - 2;
            }
            Console.WriteLine();
            Console.WriteLine("N^2 = " + P);
            Console.ReadKey();
            */

            //Задание 4 ===============================

            /*
            int N;
            double P, A;
            Console.Write("Введите вещественное число A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите целое число N: ");
            N = int.Parse(Console.ReadLine());
            P = 0;
            while (N >= 0)
            {
                P = P + Math.Pow(A,N);
                N = N - 1;
            }
            Console.WriteLine("Сумма: " + P);
            Console.ReadKey();
            */

            //Задание 5 ===============================

            /*
            int N;
            double P, A;
            Console.Write("Введите вещественное число A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите целое число N: ");
            N = int.Parse(Console.ReadLine());
            P = 0;
            while (N >= 0)
            {
                P = P + (Math.Pow(-1, N) * Math.Pow(A,N));
                N = N - 1;
            }
            Console.WriteLine("Сумма: " + P);
            Console.ReadKey();
            */
        }
    }
}
