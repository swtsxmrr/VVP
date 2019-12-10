using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_11__1_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 =====================

            /*
            int A, B;
            Console.WriteLine("Обязательное условие A<B");
            Console.Write("Введите число А: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
            */

            //Задание 2 =====================

            /*
            int A, B;
            Console.WriteLine("Обязательное условие A>B");
            Console.Write("Введите длину отрезка А: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите длину отрезка B: ");
            B = int.Parse(Console.ReadLine());
            while (A >= B)
            {
                A = A - B;
            }
            Console.Write("Незанятая часть отрезка: " + A);
            Console.ReadKey();
            */

            //Задание 3 =====================

            /*
            int v, K, N;
            Console.Write("Введите число N: ");
            N = int.Parse(Console.ReadLine());
            K = 0;
            v = 0;
            while (v < N)
            {
                K++;
                v = v + K;
            }
            Console.Write("Сумма: " + v);
            Console.ReadKey();
            */

            //Задание 4 =====================

            /*
            double P, K, S;
            Console.Write("Введите проценты: ");
            P = int.Parse(Console.ReadLine());
            S = 1000;
            K = 0;
            while (S<=1100)
            {
                S = S * ((P / 100) + 1);
                K++;
            }
            Console.WriteLine("Сумма: " + S);
            Console.WriteLine("Через сколько месяцев: " + K);
            Console.ReadKey();
            */

            //Задание 5 =====================

            /*
            int A, B;
            Console.Write("Введите число А: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            while (A != 0 && B != 0)
            {
                if (A > B) A = A % B;
                else B = B % A;            
            }
            Console.Write("Наибольший общий делитель: " + (A+B));
            Console.ReadKey();
            */

            //Задание 6 =====================
            /*
            int N, K;
            int[] F = new int[200];
            Console.Write("Введите число Фибонначчи: ");
            N = int.Parse(Console.ReadLine());
            K = 0;
            F[0] = 0;
            F[1] = 1;
            for (int i = 2; i < 200; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
                if (F[i] == N) K = i;
            }
            Console.Write("Номер числа Фибонначчи: " + K);
            Console.ReadKey();
            */
        }
    }
}
