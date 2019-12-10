using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_9__1_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1 =======================

            /*
            int A, B;
            string[] S = new string[9] { "первое ", "второе ", "третье ", "четвертое ", "пятое ", "шестое ", "седьмое ", "восьмое ", "девятое " };
            string[] D = new string[9] { "одинадцатое ", "двенадцатое ", "тринадцатое ", "четырнадцатое ", "пятнадцатое ", "шестнадцатое ", "семнадцатое ", "восемнадцатое ", "девятнадцатое " };
            string[] M = new string[12] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            Console.Write("Введите номер дня: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите номер месяца: ");
            B = int.Parse(Console.ReadLine());
            if (A == 10) Console.Write("десятое ");
            else if (A == 20) Console.Write("двадцатое ");
            else if (A == 30) Console.Write("тридцатое ");
            else if (A < 10) Console.Write(S[A - 1]);
            else if (A < 20) Console.Write(D[A % 10 - 1]);
            else if (A < 30) Console.Write("двадцать " + (S[A % 10 - 1]));
            else Console.Write("тридцать первое ");
            if (B < 13) Console.Write(M[B - 1]);
            Console.ReadKey();
            */

            //Задание 2 =======================

            /*
            string C;
            int T, h, N;
            string[] way = { "Север", "Запад", "Юг", "Восток" };
            Console.Write("Введите исходное направление робота («С» — север, «З» — запад, «Ю» — юг, «В» — восток): ");
            C = string.Format(Console.ReadLine());
            h = 0;
            if (C == "С") { h = 0; }
            else if (C == "З") { h = 1; }
            else if (C == "Ю") { h = 2; }
            else if (C == "В") { h = 3; }
            Console.Write("Введите команду (0 — продолжать движение, 1 — поворот налево, −1 — поворот направо): ");
            N = int.Parse(Console.ReadLine());
            T = (h + N) % 4;
            Console.Write("Нынешнее направление робота: " + way[T]);
            Console.ReadKey();
            */

            //Задание 3 =======================
            /*
            int k;
            string[] E = new string[] { "одно ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь  ", "девять " };
            string[] O = new string[] { "Одинадцать ", "Двенадцать ", "Тринадцать ", "Четырнадцать ", "Пятнадцать ", "Шестнадцать ", "Семнадцать ", "Восемнадцать ", "Девятнадцать " };
            string[] D = new string[] { "Десять", "Двадцать", "Тридцать", "Сорок" };
            Console.Write("Введите число от 10 до 40: ");
            k = int.Parse(Console.ReadLine());
            if (k == 10 || k == 20 || k == 30 || k == 40)
                Console.WriteLine(D[k / 10 - 1] + "учебных заданий");
            if ((k / 10 == 1) && (k % 10 != 0))
                Console.WriteLine(O[k % 10 - 1] + "учебных заданий");
            if ((k / 10 == 2) && (k % 10 != 0) && (k % 10 > 4))
                Console.WriteLine(D[k / 10 - 1] + " " + E[k % 10 - 1] + "учебных заданий");
            else if ((k / 10 == 2) && (k % 10 > 1) && (k % 10 <= 4))
                Console.WriteLine(D[k / 10 - 1] + " " + E[k % 10 - 1] + "учебных задания");
            else if ((k / 10 == 2) && (k % 10 == 1))
                Console.WriteLine(D[k / 10 - 1] + E[k % 10 - 1] + "учебное задание");
            if ((k / 10 == 3) && (k % 10 != 0) && (k % 10 > 3))
                Console.WriteLine(D[k / 10 - 1] + " " + E[k % 10 - 1] + "учебных заданий");
            else if ((k / 10 == 3) && (k % 10 > 1) && (k % 10 <= 3))
                Console.WriteLine(D[k / 10 - 1] + " " + E[k % 10 - 1] + "учебных задания");
            else if ((k / 10 == 3) && (k % 10 == 1))
                Console.WriteLine(D[k / 10 - 1] + " " + E[k % 10 - 1] + "учебное задание");
            Console.ReadLine();
            */

            //Задание 4 =======================

            /*
            int k, a, b, c;
            string[] O = new string[] { " двадцать ", " тридцать ", " сорок ", " пятдесять ", " шестьдесять ", " семьдесят ", " восемьдесят ",  "девяносто " };
            string[] D = new string[] { "Сто ", "Двести ", "Триста ", "Четыреста ", "Пятьсот ", "Шестьсот ", "Семьсот ", "Восемьсот ", "Девятьсот " };
            Console.Write("Введите число от 100 до 999: ");
            k = int.Parse(Console.ReadLine());
            a = k / 100;
            b = (k % 100) / 10;
            c = k % 10;
            if (b > 1)
            {
                string[] E = new string[] { "один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь  ", "девять " };
                Console.WriteLine(D[a - 1] + O[b - 2] + E[c - 1]);
            }
            else if (b == 0)
            {
                string[] E = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", " " };
                Console.WriteLine(D[a - 1] + E[c - 1]);
            }
            else if (b == 1)
            {
                string[] E = { "один", "две", "три", "четыр", "пят", "шест", "сем", "восем", "девят" };
                Console.WriteLine(D[a - 1] + E[c - 1] + "надцать");
            }
            Console.ReadKey();
            */

            //Задание 5 =======================
            /*
            int a, b, c;
            Console.Write("Введите год: ");
            a = int.Parse(Console.ReadLine());
            string[] CV = new string[] { "зелёно", "красно", "жёлто", "бело", "чёрно"};
            string[] ZV = new string[] { " крысы", " коровы", " тигра", " зайца", " дракона", " змеи", " лошади", " овцы", " обезъяны", " курицы", " собаки", " свиньи" };
            if (a >= 1984)
            {
                a = a - 1984;
                b = (a % 60) / 12;
                c = (a % 60) % 12;
            }
            else
            {
                a = 1983 - a;
                b = 4-(a % 60) / 12;
                c = 11-(a % 60) % 12;
            }
            if (c==2||c==3||c==4) Console.WriteLine("Год " + CV[b] + "го" + ZV[c]);
            else Console.WriteLine("Год " + CV[b] + "й" + ZV[c]);
            Console.ReadKey();
            */
        }
    }
}