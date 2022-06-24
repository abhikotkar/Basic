using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    class Static
    {
        static int x = 10;


        public Static()
        {
            x++;
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Static s = new Static();
            Static s1 = new Static();
            Static s2 = new Static();
        }
    }


    //for access non static variable to static variable always create a object of class within the statis method.
    class StaticDemo1
    {
        int x = 10;
        static int y = 20;
        static void get()
        {
            StaticDemo1 d = new StaticDemo1();
            Console.WriteLine(d.x + " " + y);
        }
        void display()
        {
            y = 500;
            Console.WriteLine(x + " " + y);

        }

        static void Main(string[] args)
        {
            StaticDemo1 s = new StaticDemo1();
            get();
            s.display();
        }
    }
    //for assign parameterised value to static variable in static or non static method always write class name before variable name
    class StaticDemo2
    {
        static int x;
        void get(int x)
        {
            StaticDemo2.x = x;
        }
        void display()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            StaticDemo2 s = new StaticDemo2();
            s.get(300);
            s.display();
        }
    }

    //create static constructor //the static constructor called automatically in one times without creating any object of class.

    class Test1
    {
        static Test1()
        {
            Console.WriteLine("This is static constructor");
        }
        public Test1(int x)
        {
            Console.WriteLine("The number is " + x);
        }
        static void Main(string[] args)
        {
            Test1 t = new Test1(200);
            Test1 t1 = new Test1(500);
        }
    }

    static class StaticClass
    {
        static int x = 100;
        static void get()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            get();

        }
    }

    //Overloading of static method

    class Static3
    {


        static void calculate(int a, int b, int c)
        {
            Console.WriteLine("Addition is " + (a + b + c));
        }

        static void calculate(int a, int b)
        {
            Console.WriteLine("Substraction is " + (a - b));
        }
        static void calculate(float a, int b)
        {
            Console.WriteLine("Multiplication is " + (a * b));
        }
        static void calculate(long a, int b)
        {
            Console.WriteLine("Division is " + (a / b));
        }
        static void Main(string[] args)
        {
            calculate(5, 6, 9);
            calculate(8, 3);
            calculate(8f, 9);
            calculate(9851263516, 5686);
        }
    }

    //

    class Calculate
    {
        int a = 20;
        static int b = 10;

        internal void addition()
        {
            Console.WriteLine("Addition is " + (a + b));
        }

        public static void division()
        {
            Calculate c = new Calculate();
            Console.WriteLine("Division is " + (c.a / b));
        }
        static void Main(string[] args)
        {

        }
    }
    class Calculate1
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate();
            c1.addition();
            Calculate.division();
        }
    }

    //static class does not contain non-static class
    static class Stud
    {
        /*public Stud()
        {
            static void Main(string[] args)
            {

            }
        }*/
    }

    //static class does not contain private constructor.

    static class Stud1
    {
        /* private Stud1()
         {
             static void Main(string[] args)
             {

             }
         }*/
    }
}
