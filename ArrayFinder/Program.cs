using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                string path;
                //path = Input.String("Укажите путь к файлу: "); //C:\Users\arxal\Desktop\Array.txt
                path = "Array.txt";
                do
                {
                    Searcher.Find(path);
                    Console.WriteLine("Если вы хотите продолжить поиск по файлу - нажмите Enter");
                    key = Console.ReadKey();
                }
                while (key.Key == ConsoleKey.Enter);
                
                Console.WriteLine("Нажмите Enter для продолжения");
                key = Console.ReadKey();
            }
            while (key.Key == ConsoleKey.Enter);
        }
    }
}