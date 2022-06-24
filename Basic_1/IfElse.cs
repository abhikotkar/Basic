using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class first
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is first program");
        }
    }



    class leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 100 == 0 && year % 400 == 0) || year % 4 == 0)
                Console.WriteLine("This year is a leap year.");
            else
                Console.WriteLine("This year is not a leap year.");

        }
    }


    class divisible511
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = int.Parse(Console.ReadLine());
            if (n % 5 == 0 && n % 11 == 0)
                Console.WriteLine(n + " is divisible by 5 and 11.");
            else
                Console.WriteLine(n + " is not divisible by 5 and 11.");

        }
    }


    class max3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 3 number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
                Console.WriteLine(n1 + " is greater number.");
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine(n2 + " is greater number.");
            else if (n3 > n1 && n3 > n2)
                Console.WriteLine(n3 + " is greater number.");
            else
                Console.WriteLine("All numbers are equal.");

        }
    }

    class vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character:");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'Y')
                Console.WriteLine(ch + " is an vowel");
            else
                Console.WriteLine(ch + " is an consonant");

        }
    }


    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition is " + (a + b));
            Console.WriteLine("Substraction is " + (a - b));
            Console.WriteLine("Multiplication is " + (a * b));
            Console.WriteLine("Division is " + (a / b));
        }
    }


    class posneg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("This number is positive.");
            else if (a < 0)
                Console.WriteLine("This number is negative.");
            else
                Console.WriteLine("Number is Zero");
        }
    }

    class chechalpha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character:");
            char ch = char.Parse(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
                Console.WriteLine("This is the character");
            else if (ch >= '0' && ch <= '9')
                Console.WriteLine("This is an digit");
            else
                Console.WriteLine("This is the special character");

        }
    }


    class evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("The given number is even.");
            else
                Console.WriteLine("The given number is odd.");
        }
    }
}
