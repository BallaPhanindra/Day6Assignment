using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
	using System;
	class DistinctCoupons
	{
			public int factorial(int n)
			{
				if (n == 0)
					return 1;
				return n * factorial(n - 1);
			}
			public int CountNum(int n)
			{
				if (n > 10)
					return 0;
				return (9 * factorial(9) /
							factorial(10 - n));
			}
		}
	}