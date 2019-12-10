using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_14__1_6_
{
    class Program
    {
        static void Main(string[] args)

        {
            //Задание 1 =================================================

            /*
            int N, K, L;
            double S;
            Console.WriteLine("Обязательное условие задачи: 1 <= K <= L <= N");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            double[] M = new double[N+1];
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Введите " + i + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 1; i <= N; i++)
            {
              Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите L: ");
            L = int.Parse(Console.ReadLine());
            Console.Write("Введите K: ");
            K = int.Parse(Console.ReadLine());
            S = 0;
            for (int i = K; i <= L; i++)
            {
                S = S + M[i];
            }
            S = S / 2;
            Console.WriteLine("Среднее арифмитическое: " + S);
            Console.ReadKey();
            */

            //Задание 2 =================================================

            /*
            int N, L;
            Console.WriteLine("Обязательное условие задачи: массив не содержит одинаковых чисел ");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            L = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i+1) + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                 Console.Write(M[i] + " ");
            }
            for (int i = 0; i < N - 2; i++)
            {
                 if (M[i] - M[i + 1] == M[i + 1] - M[i + 2] || N == 2)
                 {
                     L = M[i + 1] - M[i];
                 }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ответ: " + L);
            Console.ReadKey();
            */

            //Задание 3 =================================================

            /*
            int N, min;
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i + 1) + " число массива: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine(" ");
            min = int.MaxValue;
            for (int i = 2; i < N; i += 2)
            {
                if (A[i] <= min) min = A[i];
            }
            Console.Write("Минимальный четный элемент: " + min);
            Console.ReadKey();
            */

            //Задание 4 =================================================

            /*
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i + 1) + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            int max = -1;
            for (int i = 1; i < N - 1; i++)
            {
                if ((M[i] > M[i - 1]) && (M[i] > M[i + 1])) max = i + 1;
            }
            if (max != -1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Номер элемента локального максимума: " + max);
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Таких чисел нет!");
            }
            Console.ReadKey();
            */

            //Задание 5 =================================================

            /*
            Console.WriteLine("Обязательное условие задачи: массив должен содержать ровно два одинаковых элемента");
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            int[] M = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i + 1) + " число массива: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {               
                Console.Write(M[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                    if (M[i] == M[j])
                        Console.WriteLine("Номера одинаковых элементов массива в порядке возрастания: " + (i + 1) + " " + (j + 1));
            Console.ReadKey();
            */        

        }
    }
}
