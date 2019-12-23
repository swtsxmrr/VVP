using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Код_Лабораторной_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 =====================================================
            //удаление первого слова
            /*
            string path = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22.txt";
            string text = File.ReadAllText(path);
            Console.Write("Строка в файле: ");
            Console.Write(text);
            Console.WriteLine();
            text = text.Remove(0, text.IndexOf(' ') + 1);
            File.WriteAllText(path, text);
            Console.Write("Исправленная строка в файле: ");
            Console.Write(text);
            Console.ReadKey();
            */
            //Задание 2 =====================================================
            //звездочки
            /*
            string path = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22.txt";
            string text = File.ReadAllText(path);
            Console.Write("Введите число K (кол-во звезд): ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Введите число N (строк): ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    File.AppendAllText(path, string.Join(path, " * "));
                }
                File.AppendAllText(path, Environment.NewLine);
            }
            Console.ReadKey();
            */
            //Задание 3 =====================================================
            //в начало первого содержимое второго
            /*
            string path1 = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22.txt";
            string path2 = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22 еще.txt";
            string text1 = File.ReadAllText(path1);
            string text2 = File.ReadAllText(path2);
            Console.Write("Строка в первом файле: ");
            Console.Write(text1);
            Console.WriteLine();
            Console.Write("Строка во втором файле: ");
            Console.Write(text2);
            File.WriteAllText(path1, File.ReadAllText(path2) + text1);
            Console.ReadKey();
            */

            //Задание 4 =====================================================
            //подряд идущие пробелы
            /*
            string path = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22.txt";
            string text = File.ReadAllText(path);
            Console.Write("Строка в файле: ");
            Console.Write(text);
            File.Delete(path);
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            File.AppendAllText(path, text);
            Console.ReadKey();
            */
            //Задание 5 =====================================================
            //5 пробелов - абзац
            /*
            string path = @"C:\Лабы C#\Лаб.раб. 22\Лабораторная 22.txt";
            string text = File.ReadAllText(path);
            string pattern = @"     ";
            int k = 0;
            Regex space = new Regex(pattern);
            MatchCollection matches = space.Matches(text);
            foreach (Match mat in matches)
            {
                k++;
            }
            Console.Write("Количество абзацев: ");
            Console.Write(k);
            Console.ReadKey();
            */

        }
    }
}
