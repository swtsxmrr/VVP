using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_2__1_5__шарп
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 ==================

                /*
                float x1, x2, y1, y2, a, b;
                Console.WriteLine("Введите координаты точек: ");
                Console.Write("x1 = ");
                x1 = float.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                y1 = float.Parse(Console.ReadLine());
                Console.Write("x2 = ");
                x2 = float.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                y2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Координаты точки 1: (" + x1 + "; " + y1 + ")");
                Console.WriteLine("Координаты точки 2: (" + x2 + "; " + y2 + ")");
                double d = Math.Sqrt(Math.Abs((x2 - x1)* (x2 - x1) + (y2 - y1)*(y2 - y1)));
                Console.WriteLine("Расстояние между точками: " + d);
                Console.ReadKey();
                */

                //Задание 2 ==================

                /*
                float A, B, C;
                Console.WriteLine("Введите значения трёх точек: ");
                Console.Write("A = ");
                A = float.Parse(Console.ReadLine());
                Console.Write("B = ");
                B = float.Parse(Console.ReadLine());
                Console.Write("C = ");
                C = float.Parse(Console.ReadLine());
                float AC = Math.Abs(C - A);
                Console.WriteLine("Длина отрезка AC = " + AC);
                float BC = Math.Abs(C - B);
                Console.WriteLine("Длина отрезка BC = " + BC);
                Console.WriteLine("Сумма отрезков AC и BC = " + (AC+BC));
                Console.ReadKey();
                */

                //Задание 3 ===========================================

                /*
                float A, B, C;
                Console.WriteLine("Обязательное условие задачи - точка C лежит между точками A и B");
                Console.WriteLine("Введите значения трёх точек: ");
                Console.Write("A = ");
                A = float.Parse(Console.ReadLine());
                Console.Write("B = ");
                B = float.Parse(Console.ReadLine());
                Console.Write("C = ");
                C = float.Parse(Console.ReadLine());
                if (C > A && C < B || C > B && C < A)
                {
                    Console.WriteLine("Произведение АС и ВС: " + ((Math.Abs(C - A)) * (Math.Abs(B - C))));
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите значения заново.");
                }
                Console.ReadKey();
                */

                //Задание 4 =======================================

                /*
                int x1, x2, y1, y2;
                Console.WriteLine("Введите координаты точки 1: ");
                Console.Write("x1 = ");
                x1 = int.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты точки 2: ");          
                Console.Write("x2 = ");
                x2 = int.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                y2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Периметр равен " + (2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1))));
                Console.WriteLine("Площадь равна " + (Math.Abs(x2 - x1) * Math.Abs(y2 - y1)));
                Console.ReadKey();
                */

                //Задание 5 =======================================

            /*
                float x1, x2, x3, y1, y2, y3;
                Console.WriteLine("Введите координаты вершины 1: ");
                Console.Write("x1 = ");
                x1 = float.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                y1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты вершины 2: ");
                Console.Write("x2 = ");
                x2 = float.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                y2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты вершины 3: ");
                Console.Write("x3 = ");
                x3 = float.Parse(Console.ReadLine());
                Console.Write("y3 = ");
                y3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Площадь равна " + (0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1))));
                Console.WriteLine("Периметр равен " + (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2)) + Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1))));
                Console.ReadKey();

            */
            }
        }
    }