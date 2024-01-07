using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.Write("You are Valid For Licence");
            }
            Console.ReadKey();
        }
    }
}
