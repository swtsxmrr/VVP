using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ========================================           
            /*
            int i, j, M, K;
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы матрицы");
            int[,] A = new int[M, M];
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write($"[{i+1}][{j+1}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Матрица по спирали:");
            for (K = 0; K <= (M / 2); K++)
            {
                for (i = K; i < M - K; i++)
                    Console.Write(" " + A[i, K]);
                i--;
                for (j = K + 1; j < M - K; j++)
                    Console.Write(" " + A[i, j]);
                j--;
                for (i = M - K - 2; i > K; i--)
                    Console.Write(" " + A[i, j]);
                for (j = M - K - 1; j > K; j--)
                    Console.Write(" " + A[i, j]);
            }
            Console.ReadKey();
            */
            //Задание 2 ========================================
            /*
            int i, j, M, N, K, S = 0, P = 1;
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы матрицы");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"[{i+1}][{j+1}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Введите K: ");
            K = int.Parse(Console.ReadLine());
            for (i = 0; i < M; i++)
                for (j = 0; j < N; j++)
                    if (i == (K - 1))
                    {
                        S = A[i, j] + S;
                        P = A[i, j] * P;
                    }
            Console.WriteLine("Сумма " + K + " строки: " + S);
            Console.WriteLine("Произведение " + K + " строки: " + P);
            Console.ReadKey();
            */
            //Задание 3 =======================================
            /*
            int i, j, M, N, C = 1;
            int max = int.MaxValue;
            int minj = 0;
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы матрицы");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"[{i + 1}][{j + 1}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (j = 0; j < N; j++)
            {
                C = 1;
                for (i = 0; i < M; i++)
                {
                    C *= A[i, j];
                }
                if (C < max)
                {
                    max = C;
                    minj = j;
                }
            }
            Console.WriteLine("Минимальное произведение столбца: " + max);
            Console.WriteLine("Номер столбца: " + (minj + 1));
            Console.ReadKey();
            */
            //Задание 4 ========================================
            /*
            int i, j, M, N, k = 0;
            double S = 0, SR = 0;
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы матрицы");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"[{i + 1}][{j + 1}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (j = 0; j < N; j++)
            {
                k = 0;
                S = 0;
                for (i = 0; i < M; i++)
                {
                    S = A[i, j] + S;
                }
                SR = S / M;
                Console.WriteLine("Среднее арифметическое {0} столбца: {1} ", j + 1, SR);
                for (i = 0; i < M; i++)
                {
                    if (A[i, j] > SR) k++;
                }
                Console.WriteLine("Кол-во элементов больше среднего: " + k);
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            //Задание 5 ========================================
            /*
            int i, j, M, N;
            double S = 0;
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.WriteLine("Введите элементы матрицы");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"[{i + 1}][{j + 1}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Результат: ");
            for (j = 0; j < N; j++)
            {
                S = 0;
                for (i = 0; i < M; i++)
                {
                    if (A[i, j] % 2 != 0) { S++; }
                }
                if (S == M)
                {
                    Console.Write(" " + (j + 1));
                }
                else
                {
                    Console.Write(" " + 0);
                }
            }
            Console.ReadKey();
            */
        }
    }
}
