using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Logical_Programs
    {
        public int Reverse_Number(int number)
        {
            int numberCopy = number;
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number of {0} is {1}", numberCopy, reverse);
            return reverse;
        }

        public bool Prime_Number(int number)
        {
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
                if (count > 0)
                {
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("{0} is not a prime number  ", number);
                return false;
            }
            else
            {
                Console.WriteLine("{0} is a prime number ", number);
                return true;
            }

        }

        public bool Perfect_Number(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;

                }
            }
            if (sum == number)
            {
                Console.WriteLine("{0} is a perfect number", number);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", number);
                return false;
            }
        }
        public int Fibanocci_Series(int number)
        {

            int a = 0, b = 1, c = 0;
            for (int i = 0; i <= number; i++)
            {

                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }
            return c;
        }
    }
}
