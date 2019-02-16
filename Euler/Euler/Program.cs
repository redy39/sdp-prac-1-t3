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


            //Tapiwa Pawandiwa Problem 2
            int Fibnum = 0;
            int prev_one = 1;  //we do this because the first numbers in the fibonnaci sequence are 0,1,1,2,3...
            int prev_two= 1;
            int result = 0;

            while (Fibnum < 4000000)
            {
                if (Fibnum % 2 ==0) // this tells us whether the number is even or odd, in this case we looking for only even numbers 
                {
                    result = result + Fibnum;
                }
                Fibnum = prev_one + prev_two; // adding the two previous numbers , we calculate the next number in the fibonnaci sequence by adding the two previous numbers 
                prev_two = prev_one; // if our first number is 0 , we use force the code to go to 2 so we start the sequence, so if 2 is the next number , what is the previous number ? 1 
                prev_one = Fibnum;  // our second previous number is the number we are dealing with , we do this in order to calculate the next number 
            }
            Console.WriteLine(Convert.ToString(result));

        }
    }
}
