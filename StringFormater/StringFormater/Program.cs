using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Работа со строками";
            RealTime.GetTime();
            #region Меню
            while (true)
            {
            Console.WriteLine("Введите текст(Enter = конец ввода):");
            string Stemp = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите 1 для удаления повторяющихся слов.");
            Console.WriteLine("Нажмите 2 для удаления спец символов.");
            Console.WriteLine("Нажмите 3 для сортировки текста.");
            int x = Console.Read();
            char ch = Convert.ToChar(x);
                switch (ch)
                {
                    case '1':
                        DelRep dr = new DelRep();
                        dr.Str1 = dr.SFormat(Stemp);
                        Console.Write("Выходная строка:");
                        Console.WriteLine(dr.Str1);
                        RealTime.GetTime();
                        break;
                    case '2':
                        DelDuplicate dd = new DelDuplicate();
                        dd.Str2 = dd.SFormat(Stemp);
                        Console.Write("Выходная строка:");
                        Console.WriteLine(dd.Str2);
                        RealTime.GetTime();
                        break;
                    case '3':
                        SortAlphabet sa = new SortAlphabet();
                        sa.Str3 = sa.SFormat(Stemp);
                        Console.Write("Выходная строка:");
                        Console.WriteLine(sa.Str3);
                        RealTime.GetTime();
                        break;
                    default:
                        Console.WriteLine("Введен неправильный символ");
                        RealTime.GetTime();
                        break;
                }
            }
            #endregion 
            Console.ReadLine();
        }
    }
}
