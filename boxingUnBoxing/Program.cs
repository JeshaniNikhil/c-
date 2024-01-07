using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;
            Console.WriteLine(obj);
            int j=(int)obj;
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}