using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Series1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,old=0,New=0;
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (i <= 3)
                {
                    Console.Write(i);
                    New = i;
                    old = i - 1;
                }
                else
                {
                    int temp = old * New;
                    if (temp>n)
                    {
                        break;
                    }
                    
                    Console.Write(temp);
                    old = New;
                    New = temp;
                }
                i++;

            } while (i <= n);
            Console.ReadKey();
        }
    }
}
