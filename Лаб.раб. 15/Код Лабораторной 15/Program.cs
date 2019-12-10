using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 =================================================

            /*
            int N, zam;
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = new int[N];
            int[] B = new int[N];
            Console.WriteLine("Введите элементы массива A");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Введите элементы массива B");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                B[i] = int.Parse(Console.ReadLine());
            }          
            Console.WriteLine();           
            for (int i = 0; i < N; i++)
            {
                zam = A[i];
                A[i] = B[i];
                B[i] = zam;
            }
            Console.Write("Сформировавшийся массив A: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив B: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Массив A после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Массив В после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 2 =================================================

            /*
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = new int[N];
            float[] B = new float[N];
            float S = 0;
            Console.WriteLine("Введите элементы массива A");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив A: ");
	        for (int i = 0; i < N; i++)
    	    {
            Console.Write(A[i] + " ");
            }
            int K;
            Console.WriteLine();
            Console.Write("Массив В после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                for (K = 0; K <= i; K++)
                {
                    S += A[K];
                }
                S /= K;
                B[i] = S;
                S = 0;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 3 =================================================

            /*
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] M = new int[N];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            int X = 0;
            for (int i = 0; i < N; i++)
            {
                if (M[i] % 2 != 0) X = M[i];
            }
            if (X != 0)
            {
                for (int i = 0; i < N; i++)
                {
                    if (M[i] % 2 != 0) M[i] += X;
                }
            }
            Console.WriteLine();
            Console.Write("Массив после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 4 =================================================

            /*
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int max, min, MAXI, MINI;
            int[] M = new int[N];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                M[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            MINI = MAXI = 0;
            max = min = M[0];
            for (int i = 0; i < N; i++)
            {
                if (max < M[i])
                {
                    max = M[i];
                    MAXI = i;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (min > M[i])
                {
                    min = M[i];
                    MINI = i;
                }
            }
            if (MINI < MAXI)
            {
                for (int i = MINI + 1; i < MAXI; i++)
                {
                    M[i] = 0;
                }
            }
            else if (MAXI < MINI)
            {
                for (int i = MAXI + 1; i < MINI; i++)
                {
                    M[i] = 0;
                }
            }
            Console.WriteLine();
            Console.Write("Массив после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + " ");
            }
            Console.ReadKey();
            */

            //Задание 5 =================================================

            
            Console.WriteLine("Обязательное условие задачи: все элементы, кроме первого, упорядочены по возрастанию");
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] A = new int[N];
            int T = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < N; i++)
            {
                Console.Write((i + 1) + " число: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Сформировавшийся массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            int S = A[0];
            for (int i = 1; i < N; i++)
            {
                if (S > A[i])
                {
                    T = A[i];
                    A[i] = S;
                    A[i - 1] = T;
                }
            }
            Console.WriteLine();
            Console.Write("Массив после преобразования: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.ReadKey();
            

        }
    }
}
