using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    //Numbers between 1 to 10
    class forloop
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

    //numbers 35 to 75
    class forloop1
    {
        static void Main(string[] args)
        {
            for (int i = 35; i <= 75; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

    //numbers 125 to 85
    class forloop2
    {
        static void Main(string[] args)
        {
            for (int i = 125; i >= 85; i--)
            {
                Console.WriteLine(i);
            }
        }

    }

    //odd numbers between 25 to 45
    class forloop3
    {
        static void Main(string[] args)
        {
            for (int i = 25; i <= 45; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

    }

    //odd numbers between 1 to 20
    class forloop4
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i = i + 2)
            {
                count++;
            }
            Console.WriteLine("The total odd numbers between 1 to 20 are " + count);
        }

    }


    //table of given number
    class forloop5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }

    }

    //sum of first 10 numbers                                    
    class forloop6
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is " + sum);
        }

    }


    //factorial of given number
    class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("The factorial of " + num + " is " + fact);

        }

    }


    //check number is prime or not
    class prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    isprime = false;
            }
            if (isprime == true)
                Console.WriteLine("Given number is prime");
            else
                Console.WriteLine("Given number is not prime");

        }

    }



    //display factors of given number
    class factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factors of given number are:");
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
        }
    }

    //display sum of factors of given number
    class factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factors of given number are:");
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

            }
            Console.WriteLine("The sum of all factors is " + sum);
        }
    }



    //display the power of given number
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent:");
            int e = int.Parse(Console.ReadLine());
            //Console.WriteLine("The factors of given number are:");
            int power = b;
            for (int i = 1; i < e; i++)
            {
                power *= b;

            }
            Console.WriteLine(power);
        }
    }


    class pattern
    {
        static void Main(string[] args)
        {
            int i = 2;
            int j;
            for (; i <= 6; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                        Console.Write((i - 1));
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
