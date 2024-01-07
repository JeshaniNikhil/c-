using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Write("Enter Age:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>18)
            {
                Console.Write("You Are Valid For License");
            }
            else
            {
                Console.Write("You are not valid for License");
            }
            Console.ReadKey();
        }
    }
}
