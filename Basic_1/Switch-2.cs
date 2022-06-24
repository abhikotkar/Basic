using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    class greater2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine((n1 > n2) ? n1 + " is grater" : n2 + " is grater");
        }
    }

    class evenodd2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());

            string ans = (num % 2 == 0) ? "number is even" : "Number is odd";
            Console.WriteLine(ans);
        }
    }

    class grater3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any three numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            string ans = (n1 > n2) ? (n1 > n3) ? "First number is grater" : "Third number is grater" : (n2 > n3) ? "Second number is grater" : "Third number is grater";
            Console.WriteLine(ans);
        }
    }

    class greater3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any three numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            string ans = (n1 > n2 && n1 > n3) ? "First number is grater" : (n2 > n3) ? "Second number is grater" : "Third number is grater";
            Console.WriteLine(ans);
        }
    }

    class posnegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any numbers");
            int n1 = int.Parse(Console.ReadLine());


            string ans = (n1 > 0) ? "Number is positive" : (n1 < 0) ? "Number is negative" : "Zero";
            Console.WriteLine(ans);
        }
    }
    class switch1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Which operation you want to perform:");
            string str = Console.ReadLine();
            switch (str)
            {
                case "add":
                    Console.WriteLine("Addition is " + (a + b));
                    break;
                case "sub":
                    Console.WriteLine("Substraction is " + (a - b));
                    break;
                case "mul":
                    Console.WriteLine("Multiplication is " + (a * b));
                    break;
                case "div":
                    Console.WriteLine("Division is " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }

    }
    //2.show week day by giving numbers
    class weekdays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter week days in number formate:");
            int week = int.Parse(Console.ReadLine());
            switch (week)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Day does not exist.");
                    break;
            }
        }
    }


    //Print 1 to 5 numbers into word
    class numword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}
