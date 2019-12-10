using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_12__1_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ====================================
            /*
            double b, a;
            int i = 1;
            while (i <= 5)
            {
                Console.Write("Введите число: ");
                a = double.Parse(Console.ReadLine());
                PowerA3(a, out b);
                Console.WriteLine("Куб вашего числа: " + b);
                i++;
            }
            Console.ReadKey();
            */

            //Задание 2 ====================================

            /*
            double A, B;
            Console.Write("Введите число A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение выражения Sign(A)+Sign(B)= " + (Sign(A) + Sign(B)));
            Console.ReadKey();
            */

            //Задание 3 ====================================

            /*
            double R1, R2;
            int i = 1; 
            while (i <= 3)
            {
                Console.Write("Введите больший радиус: ");
                R1 = double.Parse(Console.ReadLine());
                Console.Write("Введите меньший радиус: ");
                R2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь кольца = " + RingS(R1, R2));
                i++;
            }
            Console.ReadKey();
            */

            //Задание 4 ====================================

            /*
            double x, y;
            Console.Write("Введите первую координату : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(Quarter(x, y) + " координатная четверть ");
            Console.ReadKey();
            */

            //Задание 5 ====================================

            /*
            long N;
            Console.Write("Введите число: ");
            N = long.Parse(Console.ReadLine());
            Console.Write("Двойной факториал вашего числа = " + Fact2(N));
            Console.ReadKey();
            */
        }

        static void PowerA3(double a, out double b)
        {
            b = Math.Pow(a, 3);
        }

        static int Sign(double k)
        {
            if (k < 0) return -1;
            else if (k == 0) return 0;
            else return 1;
        }

        static double RingS(double x, double y)
        {
            return ((x * Math.PI) - (y * Math.PI));
        }

        static double Quarter(double x, double y)
        {
            if (x > 0 && y > 0) return 1;
            else if (x < 0 && y > 0) return 2;
            else if (x < 0 && y < 0) return 3;
            else return 4;
        }

        static long Fact2(long N)
        {
            long P = 1;
            long i;
            i = N % 2;
            if (i == 0)
                for (i = 2; i <= N; i = i + 2)
                    P = P * i;
            else
                for (i = 1; i <= N; i = i + 2)
                    P = P * i;
            return P;
        }


    }
}
