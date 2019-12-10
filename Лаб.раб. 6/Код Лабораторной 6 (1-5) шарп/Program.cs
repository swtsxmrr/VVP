using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_6__1_5__шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ==============================

            /*
            int N;
            Console.Write("Введите количество секунд с начала суток: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество секунд прошедших с последней минуты: " + N % 60);
            Console.ReadKey();
            */

            //Задание 2 ==============================

            /*
            int K;
            Console.Write("Введите число, день недели которого вы хотите найти: ");
            K = int.Parse(Console.ReadLine());
            Console.WriteLine("День недели для " + K + " дня: " + K % 7);
            Console.WriteLine("0 — воскресенье, 1 — понедельник, 2 — вторник, . . . , 6 — суббота.");
            Console.ReadKey();
            */

            //Задание 3 ==============================

            /*
            int K, N;
            Console.WriteLine("Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, . . . , 6 — суббота, 7 — воскресенье.");
            Console.Write("Введите день недели с которого начался год: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите день: ");
            K = int.Parse(Console.ReadLine());
            Console.WriteLine("День недели для " + K + " дня, начавшегося с " + N + " дня недели: " + ((K + N - 2) % 7 + 1));
            Console.ReadKey();
            */

            //Задание 4 ==============================

            /*
            int A, B, C, kv;
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            C = int.Parse(Console.ReadLine());
            kv = (A / C) * (B / C);
            Console.WriteLine("Количество квадратов, размещенных на прямоугольнике со стороной C: " + kv);
            Console.WriteLine("Площадь незанятой части прямоугольника: " + (A * B - (C * C) * kv));
            Console.ReadKey();
            */

            //Задание 5 ==============================

            /*
            int A;
            Console.Write("Введите номер года: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер столетия: " + (A = (A - 1) / 100 + 1 ));
            Console.ReadKey();
            */

        }
    }
}
