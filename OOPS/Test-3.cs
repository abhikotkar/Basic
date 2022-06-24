using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    //q.1 print number between 1 to 100 except divisible by 5 or 10
    class Number1
    {
        public void display()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                    continue;
                else
                    Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Number1 n = new Number1();
            Console.WriteLine("The numbers between 1 to 100 except divisible by 5 or 10:");
            n.display();
        }
    }

    //q.2 factors of given number
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factors of " + a + " are:");
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                    Console.WriteLine(i);
            }
        }
    }

    //q.3 print numbers between 1 to50 if it is even print as it is and if odd then print its square.
    class Seriess
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 50)
            {
                if (i % 2 == 0)
                    Console.Write(" " + i);
                else
                {

                    Console.Write(" " + (i * i));
                }
                i++;
            }
        }
    }

    //q.4 fibbonacci series 1 1 2 3 5 8 ........upto 20 terms.
    class Fibbo
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


    //q.5 check number is harshad or not
    //harshad means number is divisible by sum of digits of number.
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n, r, sum = 0;

            while (temp > 0)
            {
                r = temp % 10;
                sum = sum + r;
                temp = temp / 10;


            }
            if (n % sum == 0)
                Console.WriteLine("It is the harshad number");
            else
                Console.WriteLine("It is not the harshad number");



        }
    }

    //q.6 series
    class RedBlue
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("RedBlue");
                else if (i % 3 == 0)
                    Console.WriteLine("Red");
                else if (i % 5 == 0)
                    Console.WriteLine("Blue");
                else
                    Console.WriteLine(i);

                i++;
            }
        }
    }

    //q.7 properties write for order

    class Order
    {
        private int orderid;
        private string city;
        private string custname;
        private bool isDelivered;

        public int Orderid { get => orderid; set => orderid = value; }
        public string City { get => city; set => city = value; }
        public string Custname { get => custname; set => custname = value; }
        public bool IsDelivered { get => isDelivered; set => isDelivered = value; }
    }


    class OrderInfo
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Orderid = 205;
            o.City = "Pune";
            o.Custname = "Shivraj";
            o.IsDelivered = true;

            Console.WriteLine(o.Orderid + " " + o.City + " " + o.Custname + " " + o.IsDelivered);

        }
    }
}
