using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Fibonacci
    {
        public void FindFibonacci()
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.WriteLine("Enter the Number of elements");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1+" "+n2+" ");
            for(i = 0; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
