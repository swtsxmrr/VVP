using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Лабораторной_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ============================================
            /*
            char C;
            int L, P, a;
            Console.Write("Введите символ: ");
            C = Convert.ToChar(Console.ReadLine());
            a = Convert.ToInt32(C);
            P = a - 1;
            L = a + 1;
            Console.WriteLine("Предшествующий символ: " + Convert.ToChar(P));
            Console.WriteLine("Последующий символ: " + Convert.ToChar(L));
            Console.ReadKey();
            */
            //Задание 2 ============================================
            /*
            List<char> myList = new List<char> { };
            string S;
            char P;
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            for (int i = 0; i < S.Length; i++)
            {
                P = Convert.ToChar(S[i]);
                myList.Add(P);
                myList.Add(' ');

            }
            Console.Write("Обработанная строка:  ");
            for (int i = 0; i < S.Length * 2; i++)
            {
                Console.Write(myList[i]);

            }
            Console.ReadKey();
            */
            //Задание 3 ============================================
            //на английском с большими буквами
            /*
            string S;
            int Q, c = 0;
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            for (int i = 0; i < S.Length; i++)
            {
                Q = Convert.ToInt32(S[i]);
                if (Q > 64 && Q < 91)
                {
                    c++;
                }
            }
            Console.Write("Количествово прописных букв: " + c);
            Console.ReadKey();
            */
            //Задание 4 ============================================
            /*
            List<char> myList = new List<char> { };
            string S;
            char h;
            char C;
            int k = 0;
            Console.Write("Введите символ: ");
            C = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            for (int i = 0; i < S.Length; i++)
            {
                h = Convert.ToChar(S[i]);
                if (h == C)
                {
                    myList.Add(h);
                    myList.Add(h);
                    k++;
                }
                else { myList.Add(h); }
            }
            Console.Write("Обработанная строка: ");
            for (int i = 0; i < S.Length + k; i++)
            {
                Console.Write(myList[i]);
            }
            Console.ReadKey();
            */
            //Задание 5 ============================================
            /*
            string s, s0;
            Console.Write("Введите строку S: ");
            s = Console.ReadLine();
            Console.Write("Введите строку S0: ");
            s0 = Console.ReadLine();
            int k = s.Length;
            s = s.Replace(s0, "");
            Console.Write("Количество вхождений: " + (k - s.Length) / s0.Length);
            Console.ReadKey();
            */
        }
    }
}
