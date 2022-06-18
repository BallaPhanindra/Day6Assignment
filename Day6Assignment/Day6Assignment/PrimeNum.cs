using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class PrimeNum
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Please eneter a number to check if its prime num or not :");
            int num=Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    sum++;
                }
            }
            if(sum == 2)
            {
                Console.WriteLine(num+" is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a not a prime number");
            }
        }
    }
}
