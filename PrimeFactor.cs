using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class PrimeFactor
    {
        public void Factors()
        {
            int c = 2;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                if (n % c == 0)
                {
                    Console.Write(c + " ");
                    n /= c;
                }
                else
                    c++;
            }
        }
    }
}
