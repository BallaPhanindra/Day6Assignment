using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class PerfectNum
    {
        public void PerfectNumber()
        {
            int num, sum = 0;
            Console.WriteLine("Please neter a number to check if its Perfect number");
            num=Int32.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                int rem = num % i;
                if(rem == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum==num)
            {
                Console.WriteLine(num+" is perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not a perfect number");
            }

        }
    }
}
