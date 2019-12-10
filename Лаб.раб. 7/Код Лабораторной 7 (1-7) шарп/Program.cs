using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_7__1_7__шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 ==============================

            /*
            int A, B;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Справедливы неравенства A > 2 и B <= 3: " + ((A > 2) && (B <= 3)));
            Console.ReadKey();
            */

            //Задание 2 ==============================

            /*
            int A, B, C;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Справедливо двойное неравенство A < B < C: " + ((A < B) || (B < C)));
            Console.ReadKey();
            */

            //Задание 3 ==============================

            /*
            int A;
            Console.Write("Введите число: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Данное число является четным двузначным: " + (((A < 100) && (A >= 10)) && (A % 2 == 0)));
            Console.ReadKey();
            */

            //Задание 4 ==============================

            /*
            int Q, A, B, C;
            Console.Write("Введите трехзначное число: ");
            Q = int.Parse(Console.ReadLine());
            A = Q / 100;
            B = (Q % 100) / 10;
            C = Q % 10;
            Console.Write("Цифры данного числа образуют возрастающую или убывающую последовательность: " + ((A < B) && (B < C) || (A > B) && (B > C)));
            Console.ReadKey();
            */

            //Задание 5 ==============================

            /*
            int Q, A, B, C, D;
            Console.Write("Введите четырехзначное число: ");
            Q = int.Parse(Console.ReadLine());
            A = Q / 1000;
            B = (Q % 1000) / 100;
            C = (Q % 100) / 10;
            D = Q % 10;
            Console.Write("«Данное число читается одинаково слева направо и справа налево: " + ((A == D) && (B == C)));
            Console.ReadKey();
            */

            //Задание 6 ==============================

            /*
            int a, b, c;
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Треугольник со сторонами a, b, c является прямоугольным: " + ((a * a + b * b) == (c * c) || (a * a + c * c) == (b * b) || (c * c + b * b) == (a * a)));
            Console.ReadKey();
            */

            //Задание 7 ==============================

            /*
            int a, b, c;
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Существует треугольник со сторонами a, b, c: " + ((a + b > c) && (a + c > b) && (c + b > a)));
            Console.ReadKey();
            */
        }
    }
}
