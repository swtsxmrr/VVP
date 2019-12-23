using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 =========================================
            /*
            Console.Write("Введите размер массива A: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив A: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            int k = 0;
            for (int i = 0; i < N - 1; i++)
            {
                int j = 1;
                while (A[i] == A[i + 1] && i != N - 2)
                {
                    j++;
                    i++;
                }
                if (i == N - 2 && A[N - 2] == A[N - 1])
                    j++;
                B[k] = j;
                C[k] = A[i];
                k++;
            }
            if (A[N - 1] != A[N - 2])
            {
                B[k] = 1;
                C[k] = A[N - 1];
                k++;
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив B (длины всех серий): ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(B[i] + " ");
            }                
            Console.WriteLine();
            Console.Write("Сформировавшийся массив C (значения элементов образующих серии): ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(C[i] + " ");
            }             
            Console.ReadLine();
            */
            //Задание 2 =========================================
            /*
            int i, j, k = 1, m = 0;
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите число L: ");
            int L = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            for (i = 0; i < N - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    k += 1;
                }
                else
                {
                    m = k;
                    k = 1;
                }
                if (m != 0)
                {
                    if (m > L)
                    {
                        for (j = 0; j < m; j++)
                        {
                            A[i - j] = 0;
                        }
                    }
                }
            }
            k = 0;
            Console.WriteLine();
            Console.Write("Массив после преобразования: ");
            for (i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    k += 1;
                }
                else
                {
                    k = 0;
                }
                if (k <= 2)
                {
                    Console.Write(A[i] + " ");
                }
            }
            Console.ReadKey();
            */
            //Задание 3 =========================================
            /*
            int i, K, N;
            Console.Write("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            Console.WriteLine("Введите элементы массива");
            for (i = 0; i < N; ++i)
            {
                Console.Write((i + 1) + " число массива: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите K: ");
            K = int.Parse(Console.ReadLine());
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            int C = 1, S = 1, L = (K == 1 ? 1 : 0), E = 0;
            for (i = 1; i < N; ++i)
            {
                if (A[i - 1] != A[i])
                {
                    C++;
                    if (C == K) S = i;
                    E = i;
                }
                if (C == K) L++;
            }
            Console.Write("Конечный массив: ");
            int i2 = -1;
            for (i = 0; i < S; ++i) B[++i2] = A[i];
            for (i = E; i < N; ++i) B[++i2] = A[i];
            for (i = S + L; i < E; ++i) B[++i2] = A[i];
            for (i = S; i < S + L; ++i) B[++i2] = A[i];
            for (i = 0; i < N; ++i) A[i] = B[i];
            for (i = 0; i < N; ++i) Console.Write(A[i] + " ");
            Console.ReadKey();
            */
            //Задание 4 =========================================
            /*
            double x1, x2, y1, y2, d1, d2;
            Console.WriteLine("Введите координаты первой точки");
            Console.Write("x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            Console.Write("x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = int.Parse(Console.ReadLine());
            d1 = Math.Sqrt((x1 * x1) + (y1 * y1));
            d2 = Math.Sqrt((x2 * x2) + (y2 * y2));
            if (d1 > d2) Console.WriteLine("Первая точка находится дальше от начала координат");            
            else if (d2 > d1) Console.WriteLine("Вторая точка находится дальше от начала координат");                   
            else Console.WriteLine("Точки находятся на одинаковом расстоянии");
            Console.ReadLine();
            */
            //Задание 5 =========================================
            /*
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            double[,] A = new double[N, 2];
            Console.WriteLine("Введите координаты точек");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"x{i}: ");
                A[i, 0] = double.Parse(Console.ReadLine());
                Console.Write($"y{i}: ");
                A[i, 1] = double.Parse(Console.ReadLine());
            }
            int p1 = 0, p2 = 0, p3 = 0;
            double p, pmax = 0;
            for (int i = 0; i < N; i++)
                for (int i2 = i + 1; i2 < N; i2++)
                    for (int i3 = i2 + 1; i3 < N; i3++)
                    {
                        p = 0;
                        p += Math.Sqrt(Math.Pow(A[i, 0] - A[i2, 0], 2) + Math.Pow(A[i, 1] - A[i2, 1], 2));
                        p += Math.Sqrt(Math.Pow(A[i, 0] - A[i3, 0], 2) + Math.Pow(A[i, 1] - A[i3, 1], 2));
                        p += Math.Sqrt(Math.Pow(A[i2, 0] - A[i3, 0], 2) + Math.Pow(A[i2, 1] - A[i3, 1], 2));
                        if (p > pmax)
                        {
                            p1 = i;
                            p2 = i2;
                            p3 = i3;
                            pmax = p;
                        }
                    }
            Console.WriteLine("Наибольший периметр треугольника: " + pmax);
            Console.WriteLine("Координаты вершин");
            Console.WriteLine(A[p1, 0] + ", " + A[p1, 1]);
            Console.WriteLine(A[p2, 0] + ", " + A[p2, 1]);
            Console.WriteLine(A[p3, 0] + ", " + A[p3, 1]);
            Console.ReadLine();
             */
        }
    }
}
       
    

