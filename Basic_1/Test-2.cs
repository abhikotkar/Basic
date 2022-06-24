using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    //q.1 Print number between 1 to 100 except divisible 5 or 10
    class Number
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                    continue;
                else
                    Console.WriteLine(i);
            }
        }


    }

    //q.2 predict the behaviour
    class loop
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);

        }


    }


    //q.3 predict the output
    class output
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
                k *= i;
            Console.WriteLine("k=" + k + "i=" + i);

        }


    }

    //q.4 check given number is spy or not.means adition and multiplication of digits are same.
    class spy
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

    //q.5 number is triometric or not

    class triomorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n * n;
            int r = m % 10;
            if (r == n)
                Console.WriteLine("The given number is triomorphic");
            else
                Console.WriteLine("The given number is not triomorphic");

        }
    }

    /*  q.6       1
                 333
                55555
               7777777     */

    class patternn1
    {
        static void Main(string[] args)
        {
            int max = 4;
            int temp = max;
            int k = 1;
            for (int i = 0; i < temp; i++)
            {

                for (int j = 1; j <= 7; j++)
                {


                    if (j >= max && j <= (max + (2 * i)))
                        Console.Write(k);
                    else
                        Console.Write(" ");


                }
                max--;
                Console.WriteLine();
                k++;


            }
        }
    }

    /*  q.7      * * * * *
                  * * * * 
                   * * *
                    * * 
                     *      */

    class patternn2
    {
        static void Main(string[] args)
        {
            int k = 9;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= k; j++)
                {
                    if (j < i)
                        Console.Write(" ");

                    else if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                }
                k--;
                Console.WriteLine();


            }
        }
    }

    /* q.8  1 2 3 4 5
              1 2 3 4
                1 2 3
                  1 2
                    1      */

    class patternn3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                int k = 1;
                for (int j = 1; j <= 5; j++)
                {
                    if (i == j || i <= j)
                    {
                        Console.Write(k);
                        k++;
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

    //q. 9 predict the output

    class predict
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);

            }
        }
    }

    //q. 10 check number is prime or not if is then check difference is 2 or not if both are satisfied tne numbers are twins.

    class twins
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool isp = true;
            bool isprime = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    isp = false;
                    break;
                }
            }
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isp == isprime)
            {
                if (a - b == 2 || b - a == 2)
                    Console.WriteLine("This are twins prime number");
                else
                    Console.WriteLine("This are not twins prime numbers");
            }
            else
                Console.WriteLine("This are not twins prime numbers");

        }
    }

    //q.11 print series 2 12 36 80.....upto 10m terms
    class seriess
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 10)
            {
                Console.Write(" " + ((i * i) + (i * i * i)));
                i++;
            }
        }
    }


    //q.12 print 1 to 50 if even then print as it is and if odd print negative value with its square.
    class seriess1
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 50)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                {
                    Console.Write(i - (i * 2));
                    Console.WriteLine(" " + (i * i));
                }
                i++;
            }
        }
    }

    //q.13 predict the output
    class predict1
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }

                Console.WriteLine(i);
            }
        }
    }


    //q.14 fibbonacci series 1 1 2 3 5 8 ........upto 20 terms.
    class fibbo
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int ans;
            Console.Write(a);
            Console.Write(" " + b);
            for (int i = 1; i < 19; i++)
            {
                ans = a + b;
                a = b;
                b = ans;
                Console.Write(" " + ans);
            }

        }
    }

    // q.15 sum of factorials upto n terms
    class factorials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit:");
            int limit = int.Parse(Console.ReadLine());
            int fact, sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                sum = sum + fact;
            }
            Console.WriteLine("The sum of factorial is " + sum);

        }

    }
}
