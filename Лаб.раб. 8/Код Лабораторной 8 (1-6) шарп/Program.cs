using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_8__1_6__шарп
    {
        class Program
        {
        static void Main(string[] args)
        {
            //Задание 1 ===========================

            /*
            int A, B;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            if (A == B)
            {
                A = B = 0;
            }
            if (A > B) 
            {
                B = A;
            }
            else
            {
                A = B;
            }
            Console.Write("Новые значения A и B: " + A + " " + B);
            Console.ReadKey();
            */

            //Задание 2 ===========================

            /*
            int A, B, C;
            Console.Write("Введите первое число: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            C = int.Parse(Console.ReadLine());
            if (A > C && B > C)
            {
                Console.WriteLine("Сумма наибольших чисел: " + (A + B));
            }
            else if (B > A && C > A)
            {
                Console.WriteLine("Сумма наибольших чисел: " + (B + C));
            }
            else 
            {
                Console.WriteLine("Сумма наибольших чисел: " + (A + C));
            }
            Console.ReadKey();
            */

            //Задание 3 ===========================

            /*
            double AB, AC, x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Введите A (x1;y1): ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B (x2;y2): ");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите C (x3;y3): ");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            AC = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            if ( Math.Abs(AC) == Math.Abs(AB))
            {
                Console.WriteLine("Точки равноудалены");
            }
            else if (AB < AC)
            {
                Console.WriteLine("Ближайшая точка B. Расстояние от B до A = " + AB);
            }
            else
            {
                Console.WriteLine("Ближайшая точка C. Расстояние от C до A = " + AC);
            }
            Console.ReadKey();
            */

            //Задание 4 ===========================

            /*


            */

            //Задание 5 ===========================

            /*
            int A;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            if (A > 0)
            {
                if (A % 2 == 1)
                {
                    Console.Write("Число " + A +  " положительное нечетное");
                }
                else
                {
                    Console.Write("Число " + A + " положительное четное");
                }
            }
            else if (A < 0)
            {
                if (A % 2 == -1)
                {
                    Console.Write("Число " + A + " отрицательное нечетное");
                }
                else
                {
                    Console.Write("Число " + A + " отрицательное четное");
                }
            }
            else Console.Write("Число A нулевое");
            Console.ReadKey();
            */

            //Задание 6 ===========================

            /*
            int A;
            Console.Write("Введите число A в диапазоне 1-999: ");
            A = int.Parse(Console.ReadLine());
            if (A % 2 == 0)
            {
                if (A >= 100 && A < 1000)
                {
                    Console.Write("Число " + A + " четное трехзначное");
                }
                else if (A >= 10 && A < 100)
                {
                    Console.Write("Число " + A + " четное двузначное");
                }
                else
                {
                    Console.Write("Число " + A + " четное однозначное");
                }
            }
            else
            {
                if (A >= 100 && A < 1000)
                {
                    Console.Write("Число " + A + " нечетное трехзначное");
                }
                else if (A >= 10 && A < 100)
                {
                    Console.Write("Число " + A + " нечетное двузначное");
                }
                else
                {
                    Console.Write("Число " + A + " нечетное однозначное");
                }
            }
            Console.ReadKey();
            */

        }
    }
}
