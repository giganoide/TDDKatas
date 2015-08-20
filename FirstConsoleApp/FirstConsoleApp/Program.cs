using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                Console.WriteLine("Hello world!");
            else
                Console.WriteLine("Goodbye world!");
            Console.ReadKey();
        }
    }
}
