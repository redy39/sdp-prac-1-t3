using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thapelo Marumo Problem 1
            int sum = 0;
            int i = 0;
            while ( i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0  )
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine(Convert.ToString(sum));
        }
    }
}
