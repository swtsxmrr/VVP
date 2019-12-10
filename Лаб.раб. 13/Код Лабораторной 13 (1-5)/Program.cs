using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_13__1_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ================================================

            /*
            int N, k;
            Console.WriteLine("Обязательное условие задачи - N > 0");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            k = 1;
            int[] M = new int[N];
            for (int i = 0; i < N; i++)
            {
                M[i] = k;
                k += 2;
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 2 ================================================

            /*
            double A, D;
            int N;
            Console.WriteLine("Обязательное условие задачи - N > 1");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите D: ");
            D = int.Parse(Console.ReadLine());
            double[] M = new double[N];
            for (int i = 0; i < N; i++)
            {
                 M[i] = A * (Math.Pow(D, i));
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 3 ================================================

            /*
            int A, B, k, N;
            k = 0;
            Console.WriteLine("Обязательное условие задачи - N > 2");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            M[0] = A;
            M[1] = B;
            for (int i = 2; i < N; i++)
            {
                k = 0;
                for (int j = 0; j < i; j++)
                {
                    k = k + M[j];
                }
                M[i] = k;
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 4 ================================================

            /*
            int i, N;
            Console.WriteLine("Обязательное условие задачи - N > 2");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            for (i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i+1) + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Новый массив: ");
            for (i = 1; i < N; i++)
            {
                Console.Write(M[i - 1] + " " + M[N - i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 5 ================================================

            /*
            int i, N;
            Console.WriteLine("Обязательное условие задачи - N > 0");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            for (i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i + 1) + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Элементы с нечетными номерами в порядке возрастания номеров: ");
            for (i = 1; i < N; i = i + 2)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Элементы с четными номерами в порядке убывания номеров: ");
            for (i = N - 1; i >= 2; i = i - 2)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */
        }
    }
}
