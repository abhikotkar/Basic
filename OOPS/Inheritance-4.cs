using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    //Single inheritance
    class Mobile
    {
        protected string memorysize = "128GB";

    }
    class Apple : Mobile
    {
        protected string color = "white";
        /* static void Main(string[] args)
         {
             Apple a = new Apple();
             Console.WriteLine(a.memorysize+" "+a.color);
         }*/
    }
    class MyiPhone13Pro : Apple
    {
        protected string screen = "5.4 inch";
        static void Main(string[] args)
        {
            MyiPhone13Pro a = new MyiPhone13Pro();
            Console.WriteLine(a.memorysize + " " + a.color + " " + a.screen);
        }
    }

    //e.g.1 Single inheritance

    class Animal
    {
        protected string color;
        protected int legs;

    }
    class Dog : Animal
    {
        protected string category;
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.color = "Black";
            d.legs = 4;
            d.category = "Pet";
            Console.WriteLine(d.color + " " + d.legs + " " + d.category);
        }
    }

    //e.g.2 Single inheritance

    class Manager
    {
        protected string projectname = "Circular";
        protected string experience = "4 Years";

    }
    class Employee5 : Manager
    {
        protected string post = "Team Leader";
        static void Main(string[] args)
        {
            Employee5 e = new Employee5();

            Console.WriteLine(e.projectname + " " + e.experience + " " + e.post);
        }
    }

    //e.g.3 Single inheritance

    class Owner
    {
        protected string name = "Amit";
        protected int income = 100000;

    }
    class Worker : Owner
    {
        protected int salary = 15000;
        static void Main(string[] args)
        {
            Worker w = new Worker();

            Console.WriteLine(w.name + " " + w.income + " " + w.salary);
        }
    }


    //e.g.1 Multilevel inheritance

    class Factory
    {
        protected string name = "MIDC";
        protected int income = 1000000;

    }
    class Owner1 : Factory
    {
        protected string oname = "Amey";

    }

    class Worker1 : Owner1
    {
        protected int salary = 55263;
        static void Main(string[] args)
        {
            Worker1 w = new Worker1();

            Console.WriteLine(w.name + " " + w.income + " " + w.oname + " " + w.salary);
        }
    }
}
