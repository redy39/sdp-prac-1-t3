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
            //Redy van Dyk - problem 6
            double dif = 0, sumOfSqur = 0, squrOfSum = 0;

            for (int i = 1; i<=10;i++)
            {
                sumOfSqur += i * i;
                squrOfSum += i; // remember to squr
            }

            squrOfSum = Math.Pow(squrOfSum, 2);
            dif = squrOfSum - sumOfSqur;
            Console.WriteLine(dif);
        }
    }
}
