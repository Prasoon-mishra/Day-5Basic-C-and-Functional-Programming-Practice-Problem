using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class Largest
    {
        public void LargestAmongThree()
        {
            Console.WriteLine("Enter the first number");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int o = Convert.ToInt32(Console.ReadLine());
            if(n>m && n>o)
            {
                Console.WriteLine("n is the the largest"+n);
            }
            else if(m>n && m>o)
            {
                Console.WriteLine("m is the largest" + m);
            }
            else
            {
                Console.WriteLine("o is the largest" + o);
            }
        }
    }
}
