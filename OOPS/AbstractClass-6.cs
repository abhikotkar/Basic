using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    abstract class Animals
    {
        public int x = 90;
        public static int y = 100;

        public Animals()
        {
            Console.WriteLine("Animal COnstructor");
        }
        public abstract void show();//abstract method

        public void myAnimal()//non abstract method or concrete method
        {
            Console.WriteLine("My Animal");
        }
    }

    class Dogs1 : Animals
    {
        public Dogs1()
        {
            Console.WriteLine("Dog Constructor");

        }

        public override void show()
        {
            Console.WriteLine("Dog " + x + " " + y);
        }
    }

    class AbstractDemo
    {
        static void Main(string[] args)
        {

            Animals a = new Dogs1();
            a.show();
            a.myAnimal();


        }
    }


    abstract class Animals1
    {
        public int x = 100;
        public static int y = 500;

        public Animals1(string name)
        {
            Console.WriteLine("Animal COnstructor " + name);
        }
        public abstract void show();//abstract method

        public void myAnimal()//non abstract method or concrete method
        {
            Console.WriteLine("My Animal");
        }
    }

    abstract class Dogs2 : Animals1
    {
        public Dogs2() : base("Monty")
        {
            Console.WriteLine("Dog Constructor");

        }

        /* public override void show()
         {
             Console.WriteLine("Dog " + x + " " + y);
         }*/
    }

    class BabyDog : Dogs2
    {

        public override void show()
        {
            Console.WriteLine("BabyDog " + x + " " + y);
        }
    }
    class AbstractDemo1
    {
        static void Main(string[] args)
        {

            Animals1 a = new BabyDog();
            a.show();
            a.myAnimal();


        }
    }
}
