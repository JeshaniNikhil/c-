using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []a=new int[5];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;
            foreach(int i in a)
            {
                Console.WriteLine(i+" ");
            }
            Console.ReadKey();
        }
    }
}