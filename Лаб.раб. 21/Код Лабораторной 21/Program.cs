using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Код_Лабораторной_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 ===============================
            /*
            char[] S;
            Console.Write("Введите строку: ");
            S = Console.ReadLine().ToCharArray();
            int k = 1;
            for (int i = 0; i < S.Length; i++)
            {
                if ((S[i] == ' ') && (S[i - 1] != ' '))
                {
                    k++;
                }
            }
            Console.Write("Количество слов в строке: " + k);
            Console.ReadKey();
            */
            //Задание 2 ===============================
            /*
            string S;
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            string W = (from min in S.Split(' ')
                              orderby min.Length
                              select min).First();
            Console.Write("Длина самого короткого слова в строке: ");
            Console.Write(W.Length);
            Console.ReadKey();
            */
            //Задание 3 ===============================
            /*
            char[] S;
            char c;
            Console.Write("Введите строку: ");
            S = Console.ReadLine().ToArray();
            c = S[0];
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == c)
                {
                    S[i] = '.';
                }
            }
            Console.Write("Преобразованная строка: ");
            Console.Write(S);
            Console.ReadKey();
            */
            //Задание 4 ===============================
            /*
            string S;
            char[] GL = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'И', 'и', 'О', 'о', 'У', 'у', 'ы', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < GL.Length; j++)
                {
                    if (S[i] == GL[j])
                    {
                        k++;
                    }
                }
            }
            Console.Write("Количество гласных в строке: ");
            Console.Write(k);
            Console.ReadKey();
            */
            //Задание 5 ===============================
            //C:\Лабы C#\Лаб.раб. 21\Код Лабораторной 21
            /*
            string FullPath;
            Console.Write("Введите полный путь к файлу: ");
            FullPath = Console.ReadLine();
            Console.Write("Имя файла: ");
            Console.Write(Path.GetFileNameWithoutExtension(FullPath));
            Console.ReadKey();
            */
            //Задание 6 ===============================
            //C:\Лабы C#\Лаб.раб. 21\Код Лабораторной 21
            /*
            string FullPath;
            Console.Write("Введите полный путь к файлу: ");
            FullPath = Console.ReadLine();
            if ((char)(FullPath.Split('\\').Length) > 2)
            {
                Console.Write("Имя файла: ");
                Console.WriteLine(FullPath.Split('\\')[FullPath.Split('\\').Length - 2]);
            }
            else Console.Write("Имя файла: \\ ");
            Console.ReadKey();
            */
            //Задание 7 ===============================
            /*
            string S;
            Console.Write("Введите строку: ");
            S = Console.ReadLine();
            Console.Write("Преобразованная строка: ");
            for (int i = 0; i < S.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(S[i]);
                }
            }
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(S[i]);
                }
            }
            Console.ReadKey();
            */
        }
    }
}
