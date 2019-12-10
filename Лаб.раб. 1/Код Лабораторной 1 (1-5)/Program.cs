using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_1__1_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 ========================================================
            
            /*
            int a, b;                                       
            Console.WriteLine("Введите значения сторон: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());                //ввод a
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());                //ввод b
            Console.WriteLine("S = " + a * b);                //вывод S
            Console.WriteLine("P = " + 2 * (a + b));          //вывод P
            Console.ReadKey();                                //антизакрытие консоли
            */
            

            //Задание 2 =============================================

            /*

            const double pi = 3.14;                               //устанавливаем значение pi
            Console.Write("Введите значение диаметра: " );
            int d = int.Parse(Console.ReadLine());                //ввод значения диаметра
            Console.WriteLine("L = " + d * pi);                   //вывод длины окружности
            Console.ReadKey();                                    //антизакрытие консоли
            
            */

            //Задание 3 ==============================================

            
            /*
            float a, b;                                                       //задать тип переменной
            Console.Write("Введите значение a: ");                            //вывод строки на консоль
            a = float.Parse(Console.ReadLine());                              //считываем введенное значение
            Console.Write("Введите значение b: ");                            //вывод строки на консоль
            b = float.Parse(Console.ReadLine());                              //считываем введенное значение
            Console.WriteLine("Среднее арифметическое = " + ((a + b) / 2));   //считываем и выводим
            Console.ReadKey();                                                //антизакрытие консоли
            */
            

            //Задание 4 ==============================================

            
            /*
            float a, b;                                                                     
            Console.WriteLine("Введите ненулевые значения переменных");    
            Console.Write("Введите значение a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Сумма квадратов переменных: " + ((a * a) + (b * b)));
            Console.WriteLine("Разность квадратов переменных: " + ((a * a) - (b * b)));
            Console.WriteLine("Произведение квадратов переменных: " + ((a * a) * (b * b)));
            Console.WriteLine("Частное квадратов переменных: " + ((a * a) / (b * b)));
            Console.ReadKey();
            */
            

            //Задание 5 ================================================

          
            float a, b;
            Console.WriteLine("Введите ненулевые значения переменных");
            Console.Write("Введите значение a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Сумма модулей переменных: " + (Math.Abs(a) + Math.Abs(b)));
            Console.WriteLine("Разность модулей переменных: " + (Math.Abs(a) - Math.Abs(b)));
            Console.WriteLine("Произведение модулей переменных: " + (Math.Abs(a) * Math.Abs(b)));
            Console.WriteLine("Частное модулей переменных: " + (Math.Abs(a) / Math.Abs(b)));
            Console.ReadKey();
            

        }
    }
}
