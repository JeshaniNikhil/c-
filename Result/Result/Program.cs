using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Result
{
    class Program
    {
        static void Main(string[] args)
        {
            int total=0;
            float per=0;
            String grade="", res="";
            Console.WriteLine("Enter Marks 1:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 2:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 3:");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 4:");
            int m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 5:");
            int m5 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3 + m4 + m5;
            if ((m1 <= 100 && m2 <= 100 && m3 <= 100 && m4 <= 100 && m5 <= 100) && (m1 > 0 && m2 > 0 && m3 > 0 && m4 > 0 && m5 > 0))
            {
                if (m1 >= 40 && m2 >= 40 && m3 >= 40 && m4 >= 40 && m5 >= 40)
                {
                    Console.WriteLine("Pass");
                    per = total / 4;
                    if (per > 80)
                    {
                        grade = "A";
                    }
                    else if (per > 70)
                    {
                        grade = "B";
                    }
                    else if (per > 60)
                    {
                        grade = "C";
                    }
                    else if (per > 50)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "E";
                    }

                }
                else
                {
                    Console.WriteLine("Fail");
                    grade = "F";
                }
                Console.WriteLine("Total:"+total);
                Console.WriteLine("Percentage:"+per);
                Console.WriteLine("Grade:"+grade);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Input");
            }
            Console.ReadKey();
        }
    }
}
