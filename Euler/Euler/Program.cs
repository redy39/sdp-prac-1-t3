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

            for (int i = 1; i <= 10; i++)
            {
                sumOfSqur += i * i;
                squrOfSum += i; // remember to squr
            }

            squrOfSum = Math.Pow(squrOfSum, 2);
            dif = squrOfSum - sumOfSqur;
            Console.WriteLine(dif);

            //Thapelo Marumo Problem 1
            int sum = 0;
            int count = 0;
            while ( count < 1000)
            {
                if (count % 3 == 0 || count % 5 == 0  )
                {
                    sum += count;
                }
                count++;
            }
            Console.WriteLine(Convert.ToString(sum));
        }
    }
}
