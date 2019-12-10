using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_4__1_6__шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ===================================================

            /*
            float A;
            const double pi = 3.1415;
            Console.Write("Введите значение угла в градусах: ");
            A = float.Parse(Console.ReadLine());
            double R = ((A / 180) * pi);
            Console.Write("Значение угла в радианах: " + R);
            Console.ReadKey();
            */

            //Задание 2 ===================================================

            /*
            double R;
            const double pi = 3.1415;
            Console.Write("Введите значение угла в радианах: ");
            R = double.Parse(Console.ReadLine());
            double A = ((R / pi) * 180);
            Console.Write("Значение угла в радианах: " + A);
            Console.ReadKey();
            */

            //Задание 3 ===================================================

            /*
            float A, X, Y, Kg;
            Console.Write("Введите Х (конфеты в кг): ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Введите А (стоимость Х конфет): ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Введите Y (желаемый вес конфет): ");
            Y = float.Parse(Console.ReadLine());
            Kg = (A / X);
            Console.WriteLine("Цена за 1 кг конфет: " + Kg);
            Console.Write("Цена за " + Y + " кг конфет: " + Y * Kg);
            Console.ReadKey();
            */

            //Задание 4 ===================================================

            /*
            float V1, V2, S, T;
            Console.Write("Введите скорость 1 автомобиля(км/ч): ");
            V1 = float.Parse(Console.ReadLine());
            Console.Write("Введите скорость 2 автомобиля(км/ч): ");
            V2 = float.Parse(Console.ReadLine());
            Console.Write("Введите расстояние между ними(км): ");
            S = float.Parse(Console.ReadLine());
            Console.Write("Введите время(ч): ");
            T = float.Parse(Console.ReadLine());
            if (V1 >= V2)
            {
                Console.Write("Расстояние между автомобилями через " + T + " ч: " + (S + (V1 - V2) * T) + " км");
            }
            else
            {
                Console.Write("Расстояние между автомобилями через " + T + " ч: " + (S + (V2 - V1) * T) + " км");
            }
            Console.ReadKey();
            */

            //Задание 5 ===================================================

            /*
            float A, B, x;
            Console.Write("Введите A (коэффициент не равен 0): ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = float.Parse(Console.ReadLine());
            x = (-B / A);
            Console.WriteLine("Идёт извлечение корня A·x + B = 0...");
            Console.Write("Корень x = " + x);
            Console.ReadKey();
            */

            //Задание 6 ===================================================

            /*
            float A1, A2, B1, B2, C1, C2, K;
            Console.Write("Введите A1: ");
            A1 = float.Parse(Console.ReadLine());
            Console.Write("Введите A2: ");
            A2 = float.Parse(Console.ReadLine());
            Console.Write("Введите B1: ");
            B1 = float.Parse(Console.ReadLine());
            Console.Write("Введите B2: ");
            B2 = float.Parse(Console.ReadLine());
            Console.Write("Введите C1: ");
            C1 = float.Parse(Console.ReadLine());
            Console.Write("Введите C2: ");
            C2 = float.Parse(Console.ReadLine());
            K = A1 * B2 - A2 * B1;
            Console.WriteLine("При введеных коэффициентах значения равны: ");
            Console.WriteLine("x = " + (C1 * B2 - C2 * B1) / K);
            Console.WriteLine("y = " + (A1 * C2 - A2 * C1) / K);
            Console.ReadKey();
            */
        }
    }
}
