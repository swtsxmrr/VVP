using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 =========================================

            /*
            int N, A;
            A = 0;
            Console.WriteLine("Обязательное условие задачи: ввести два соседних одинаковых элемента");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] P = new int[N];
            int[] V = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                P[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N - 1; i++)
            {
                if (P[i] != P[i + 1])
                {
                    V[A] = P[i];
                    A++;
                }
            }
            V[A] = P[N - 1];
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
               Console.Write(P[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Массив после преобразования: ");
            for (int i = 0; i <= A; i++)
            {
                Console.Write(V[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 2 =========================================

            /*
            int N, k, A, R = 1;
            Console.WriteLine("Обязательное условие задачи: ввести два одинаковых элементы");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[] P = new int[N];
            int[] V = new int[N];
            int[] P1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                P[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                k = 0;
                for (int j = 0; j < N; j++)
                {
                    if (P[i] == P[j])
                    {
                        k++;
                    }
                }
                if (k == 2)
                {
                    P1[i] = P[i];
                }
            }
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(P[i] + " ");
            }
            for (int i = 0; i < N; i++)
            {
                A = 1;
                for (int j = 0; j < N; j++)
                {
                    if (P[i] == P1[j])
                    A = int.MaxValue;
                }
                if (A == 1)
                {
                    V[R] = P[i];
                    R++;
                }
            }
            Console.WriteLine();           
            Console.Write("Массив после преобразования: ");
            for (int i = 1; i < R; i++)
            {
                Console.Write(V[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Размер массива: " + (R-1));
            Console.ReadKey();
            */

            //Задание 3 =========================================

            /*
            float T;
            int i, mini = 0, maxi = 0, N, j = 0;
            double max, min;
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            float[] A = new float[N];
            float[] B = new float[N + 2];
            for (i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                A[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            min = float.MaxValue;
            max = float.MinValue;
            for (i = 0; i < N; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    mini = i;
                }
                if (A[i] > max)
                {
                    max = A[i];
                    maxi = i;
                }
            }
            for (i = 0; i < N + 2; i++)
            {
                T = 0;
                if (j == mini && j == 0)
                {
                    B[j] = 0;
                    i++;
                }
                else if (j == mini)
                {
                    B[i] = 0;
                    i++;
                }
                if (j == maxi)
                {
                    B[i + 1] = 0;
                    T = 1;
                }
                if (i < N + 2 && i >= 0) B[i] = A[j];
                if (T == 1) i++;
                if (j < N) j++;
            }
            Console.Write("Массив после преобразования: ");
            for (i = 0; i < N + 2; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 4 =========================================

            /*
            int i, N, c, j = 0;
            Console.WriteLine("Обязательное условие задачи: ввести отрицательные элементы");
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            float[] M = new float[N];
            for (i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                M[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < N; i++)
            {
                if (M[i] < 0)
                {
                    j++;
                }
            }
            float[] K = new float[N + j];
            c = 0;
            for (i = 0; i < N; i++)
            {
                K[c] = M[i]; ;
                if (K[c] < 0)
                {
                    K[c + 1] = 0;
                    c++;
                }
                c++;
            }
            Console.Write("Массив после преобразования: ");
            for (i = 0; i < N + j; i++)
            {
                Console.Write(K[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 5 =========================================

            
            int i, N, j = 0, c;
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            float[] M = new float[N];
            for (i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число массива: ");
                M[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Сформировавшийся массив: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < N; i++)
            {
                if (M[i] > 0)
                {
                    j++;
                }
            }
            float[] K = new float[N + j];
            c = N + j - 1;
            for (i = N - 1; i >= 0; i--)
            {
                K[c] = M[i];
                if (K[c] > 0)
                {
                    K[c - 1] = 0;
                    c--;
                }
                c--;
            }
            Console.Write("Массив после преобразования: ");
            for (i = 0; i < N + j; i++)
            {
                Console.Write(K[i] + " ");
            }
            Console.ReadKey();
            
        }
    }
}