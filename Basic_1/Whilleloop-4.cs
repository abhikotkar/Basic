using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    //print 1 to 10
    class whileloop
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

    //print 10 to 1
    class rev1to10
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }

    //print 86 to 25
    class rev86to25
    {
        static void Main(string[] args)
        {
            int i = 86;
            while (i >= 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }


    //print series 1 2 9 4 25 6.....
    class series1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of series:");
            int limit = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= limit)
            {
                if (i % 2 == 0)
                    Console.Write(" " + i);
                else
                    Console.Write(" " + (i * i));
                i++;
            }
        }
    }

    //print series 2 12 36 80.....
    class series2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of series:");
            int limit = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= limit)
            {
                Console.Write(" " + ((i * i) + (i * i * i)));
                i++;
            }
        }
    }

    //print sum of digits
    class digitsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum += rem;
                num /= 10;

            }

            Console.WriteLine("The sum of digits is " + sum);
        }
    }

    //check no. is spy or not
    class spy1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int rem, sum = 0, mul = 1;
            while (num > 0)
            {
                rem = num % 10;
                sum += rem;
                mul *= rem;
                num /= 10;

            }

            if (sum == mul)
                Console.WriteLine("The given number is spy number");
            else
                Console.WriteLine("The given number is not spy number");
        }
    }

    //print reverce number
    class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int rem, rev = 0;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;

            }

            Console.WriteLine("The reverce number is " + rev);
        }
    }

    //check given number is palindrom or not
    class palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num, rem, rev = 0;
            while (temp > 0)
            {
                rem = temp % 10;
                rev = rev * 10 + rem;
                temp /= 10;

            }
            if (num == rev)
                Console.WriteLine("The given number is palindrom number");
            else
                Console.WriteLine("The given number is not palindrom number");
        }
    }

    //check given number is armstrong or not
    class armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num, rem, sum = 0;
            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp /= 10;

            }
            if (num == sum)
                Console.WriteLine("The given number is armstrong number");
            else
                Console.WriteLine("The given number is not armstrong number");
        }
    }


    //print sum of first digit and last digit of number
    class sumdigitfl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int rem;
            rem = num % 10;
            while (num > 10)
                num /= 10;


            Console.WriteLine("The sum of first digits and last digit is " + (rem + num));
        }
    }
}
