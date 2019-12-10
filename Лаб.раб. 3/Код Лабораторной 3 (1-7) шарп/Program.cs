using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_3__1_7__шарп
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 ============================================

            /*
            float A, B, k;
            Console.WriteLine("Введите значения: ");
            Console.Write("A = ");
            A = float.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = float.Parse(Console.ReadLine());
            k = A;
            A = B;
            B = k;
            Console.WriteLine("Полученные значения: ");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.ReadKey();
            */

            //Задание 2 ============================================

            /*
            float A, B, C, k;
            Console.WriteLine("Введите значения: ");
            Console.Write("A = ");
            A = float.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = float.Parse(Console.ReadLine());
            Console.Write("C = ");
            C = float.Parse(Console.ReadLine());
            k = B;
            B = A;
            A = C;            
            C = k;
            Console.WriteLine("Полученные значения: ");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.ReadKey();
            */

            //Задание 3 ============================================

            /*
            float A, B, C, k;
            Console.WriteLine("Введите значения: ");
            Console.Write("A = ");
            A = float.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = float.Parse(Console.ReadLine());
            Console.Write("C = ");
            C = float.Parse(Console.ReadLine());
            k = A;
            A = B;
            B = C;
            C = k;
            Console.WriteLine("Полученные значения: ");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.ReadKey();
            */

            //Задание 4 ===============================================

            /*
            float y, x;
            Console.WriteLine("Введите x для уравнения y=3x^6-6x^2-7: ");
            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("y= " + (3 * Math.Pow(x, 6) + 6 * Math.Pow(x, 2) - 7));
            Console.ReadKey();
            */

            //Задание 5 ===============================================

            /*
            float y, x;
            Console.WriteLine("Введите x для уравнения y=4(x-3)^6-7(x-3)^3+2: ");
            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("y= " + (4 * Math.Pow(x-3, 6) - 7 * Math.Pow(x-3, 3) + 2));
            Console.ReadKey();
            */

            //Задание 6 ===============================================

            /*
            float A, k;
            Console.Write("Введите значение A =  ");
            A = float.Parse(Console.ReadLine());
            k = A * A;
            k = k * k;
            Console.WriteLine("A^8 = " + k * k);
            Console.ReadKey();
            */

            //Задание 7 ===============================================
            

            float A, k, k1;
            Console.Write("Введите значение A =  ");
            A = float.Parse(Console.ReadLine());
            k = A * A * A;
            k1 = k * k;
            Console.WriteLine("A^15 = " + (k1 * k1) * k);
            Console.ReadKey();
            

        }
    }
}
