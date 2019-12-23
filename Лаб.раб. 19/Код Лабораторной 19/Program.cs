using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ===============================================
            /*
            int i, j, M, N, max, min, p, maxi = 0, maxj = 0, mini = 0, minj = 0;
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
            for (i = 0; i < M; i++)
            {
                min = int.MaxValue; max = int.MinValue;
                for (j = 0; j < N; j++)
                {
                    if (A[i, j] < min) { min = A[i, j]; minj = j; mini = i; }
                    if (A[i, j] > max) { max = A[i, j]; maxj = j; maxi = i; }
                }
                p = A[maxi, maxj];
                A[maxi, maxj] = A[mini, minj];
                A[mini, minj] = p;
            }
            Console.Write("Обработанная матрица: ");
            for (i = 0; i < M; i++)
            {
                Console.WriteLine("\t");
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
            }
            Console.ReadKey(); 
            */
            //Задание 2 ===============================================
            /*
            int i, j, M, N, max, min, p, maxj = 0, minj = 0;
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
            min = int.MaxValue; max = int.MinValue;
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        maxj = j;
                    }
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        minj = j;
                    }
                }
            }
            for (i = 0; i < M; i++)
            {
                p = A[i, maxj];
                A[i, maxj] = A[i, minj];
                A[i, minj] = p;
            }
            Console.WriteLine("Максимальное значение: {0}", max);
            Console.WriteLine("Минимальное значение: {0}", min);
            Console.WriteLine();
            Console.Write("Обработанная матрица: ");
            for (i = 0; i < M; i++)
            {
                Console.WriteLine("\t");
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0}  ", A[i, j]);
                }
            }
            Console.ReadKey(); 
            */
            //Задание 3 ===============================================
            /*
            int i, j, M, N, K, W, C;
            Console.WriteLine("Обязательное условие: M и N - четные");
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
            K = N / 2;
            W = M / 2;
            for (i = 0; i < W; i++)
            {
                for (j = 0; j < K; j++)
                {
                    C = A[i, j];
                    A[i, j] = A[i + W, j + K];
                    A[i + W, j + K] = C;
                }
            }
            Console.Write("Обработанная матрица: ");
            for (i = 0; i < M; i++)
            {
                Console.WriteLine("\t");
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
            }
            Console.ReadKey();
            */

            //Задание 4 ===============================================
            /*
            int i, j, M, N, l, b;
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
            for (i = 0; i < M; i++)
                for (l = i + 1; l < M; l++)
                    if (A[i, 0] > A[l, 0])
                    {
                        for (j = 0; j < N; j++)
                        {
                            b = A[i, j];
                            A[i, j] = A[l, j];
                            A[l, j] = b;
                        }
                    }
            Console.WriteLine("Обработанная матрица: ");
            for (i = 0; i < M; i++)
            {
                Console.WriteLine("\t");
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
            }
            Console.ReadKey(); 
            */
            //Задание 5 ===============================================
            /*
            int i, j, M;
            Random rnd = new Random();
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] A = new int[M, M];
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(0, 5);
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }        
            int S, K, v = 0;
            for (i = 0; i < M * 2 - 1; ++i)
            {
                S = 0;
                K = i;
                if (i >= M) { K = M - 1; ++v; }
                for (j = K; j > v - 1; --j)
                {
                    S += A[K + v - j, j];
                }
                Console.Write("\nCумма {0} диагонали: {1}", i + 1, S);
            }
            Console.ReadKey();
            */

        }
    }
}
