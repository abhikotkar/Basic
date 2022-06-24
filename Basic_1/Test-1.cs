using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    class equilateral
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three side lengths of triangle:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == b && a == c)
                Console.WriteLine("This is equilateral triangle.");
            else
                Console.WriteLine("This is not equilateral triangle.");
        }
    }

    class sub5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of five subjects out of 100:");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int s4 = int.Parse(Console.ReadLine());
            int s5 = int.Parse(Console.ReadLine());
            int total = s1 + s2 + s3 + s4 + s5;
            float avg = total / 5;
            float perc = total / 5;
            Console.WriteLine("The total marks of five subjects are " + total);
            Console.WriteLine("The average marks of five subjects are " + avg);
            Console.WriteLine("Percentage " + perc);
        }
    }
    class leap1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 100 != 0 && year % 400 == 0) || year % 400 == 0)
                Console.WriteLine("This year is a leap year.");
            else
                Console.WriteLine("This year is not a leap year.");

        }
    }

    class div511
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

    class maximum3
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

    class vowel
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

    class simplecalculator
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

    class alpha
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

    class evenodd1
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

    //calculate gross salary
    class salary
    {
        static void Main(string[] args)
        {
            int hra = 0, da = 0, ga;
            Console.WriteLine("Enter basic salary:");
            int basic = int.Parse(Console.ReadLine());
            if (basic < 10000)
            {
                hra = basic * 20 / 100;
                da = basic * 80 / 100;
            }
            else if (basic < 20000)
            {
                hra = basic * 25 / 100;
                da = basic * 90 / 100;
            }
            else if (basic >= 20000)
            {
                hra = basic * 30 / 100;
                da = basic * 95 / 100;
            }

            ga = basic + hra + da;
            Console.WriteLine("The gross salary is " + ga);
        }
    }

    //calculate amount of electricity bill
    class electricity
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter how many units:");
            int unit = int.Parse(Console.ReadLine());
            double amt;
            if (unit <= 50)
                amt = 0.50 * unit;
            else if (unit <= 150)
                amt = 25 + ((unit - 50) * 0.75);
            else if (unit <= 250)
                amt = 100 + ((unit - 150) * 1.20);
            else
                amt = 220 + ((unit - 250) * 1.50);

            double surcharge = amt * 0.20;
            double total = amt + surcharge;
            Console.WriteLine("Thw total bill is " + total);
        }




    }
}
