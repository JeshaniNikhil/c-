using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operation:");
            char c;
            c = Console.ReadLine()[0];
            switch (c)
            {
                case '+':
                    Console.Write(a + b);
                break;
                case '-':
                    Console.Write(a - b);
                    break;
                case '*':
                    Console.Write(a - b);
                    break;

                case '/':
                    Console.Write(a - b);
                    break;

                case '%':
                    Console.Write(a - b);
                    break;
                default:
                    Console.Write("invalid Symbol");
                    break;
            }
        }
    }
}
