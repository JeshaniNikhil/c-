using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace foreachloopjagedarrray
{
    internal class Class1
    {
        static void Main(string[] args)
        { 
            int[][] num = new int[3][];
            num[0] = new[] { 1, 2, 3 };
            num[1] = new []{ 1, 2, 3, 4 };
            num[2] = new []{ 2, 3, 4, 5, 6, 7 };
            foreach(int[] i in num)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
