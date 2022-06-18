using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class ReversingNum
    {
        public void Reverse()
        {
            Console.WriteLine("Please enter a number to be reversed");
            int num=Int32.Parse(Console.ReadLine());
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                Console.Write(rem);
                num = num / 10;
            }
        }
    }
}