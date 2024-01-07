using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Write("Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int sub= a - b;
            int mul = a * b;
            int div= a / b;
            int mod= a % b;
            Console.WriteLine("Sum is :" + sum);
            Console.WriteLine("Substraction is :" + sub);
            Console.WriteLine("Multiplication is :" + mul);
            Console.WriteLine("Division is :" + div);
            Console.WriteLine("Modular  is :" + mod);
            Console.ReadKey();
        }
    }
}
