using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    //Hierarchical , base keyword, method overriding or runtime polymorphism(virtual and override) and sealed keyword.
    class HierarchicalInheritance
    {
    }

    class Laptop
    {
        public int prize = 50000;
    }
    class Dell : Laptop
    {
        public void show()
        {
            prize = 52560;
            Console.WriteLine("Dell prize " + prize);
        }
    }
    class HP : Laptop
    {
        public void display()
        {
            // prize =36000;
            Console.WriteLine("HP prize " + prize);
        }
    }
    class Accer : Laptop
    {
        public void output()
        {
            prize = 36521;
            Console.WriteLine("Accer prize " + prize);
        }
    }

    class Mylaptops
    {
        static void Main(string[] args)
        {

            Accer s = new Accer();
            s.output();
            HP h = new HP();
            h.display();
            Dell d = new Dell();
            d.show();
        }

    }

    //example of hierarchical inheritance

    class Mymobile
    {
        protected string ram = "4 GB";
        protected string rom = "128 GB";
        protected string color = "white";

    }
    class Samsung : Mymobile
    {
        protected string mobileseries;

    }
    class Nokia : Mymobile
    {
        protected string mobileseries;



    }
    class GalaxyM12 : Samsung
    {

        public GalaxyM12()
        {
            mobileseries = "Sansung Galaxy M12";
            ram = "8 GB";
            rom = "64 GB";
            color = "Black";
            Console.WriteLine("RAM=" + ram + " ROM=" + rom + " Color=" + color + " Series=" + mobileseries);
        }
    }

    class GalaxyM32 : Samsung
    {

        public GalaxyM32()
        {
            mobileseries = "Samsung Galaxy M32";
            ram = "8 GB";
            rom = "64 GB";
            color = "Black";
            Console.WriteLine("RAM=" + ram + " ROM=" + rom + " Color=" + color + " Series=" + mobileseries);
        }
    }

    class NokiaG21 : Nokia
    {

        public NokiaG21()
        {
            mobileseries = "Nokia G21";
            Console.WriteLine("RAM=" + ram + " ROM=" + rom + " Color=" + color + " Series=" + mobileseries);
        }
    }
    class NokiaC01 : Nokia
    {

        public NokiaC01()
        {
            mobileseries = "Nokia C01";
            Console.WriteLine("RAM=" + ram + " ROM=" + rom + " Color=" + color + " Series=" + mobileseries);
        }
    }
    class MyMobileDemo
    {
        static void Main(string[] args)
        {
            NokiaC01 n = new NokiaC01();
            GalaxyM12 s = new GalaxyM12();
            NokiaG21 n1 = new NokiaG21();
            GalaxyM32 s1 = new GalaxyM32();
        }
    }

    //method overiding

    class Animal1
    {
        protected int legs = 2;

        public Animal1()
        {
            Console.WriteLine("Animal");
        }
        public Animal1(int x)
        {
            Console.WriteLine("x= " + x);
        }
        public void foo()
        {
            Console.WriteLine("Parent");

        }
    }
    class Dog1 : Animal1
    {
        int legs = 4;

        public Dog1()
        {
            Console.WriteLine("Dog");
        }
        public Dog1(int x) : base(x)
        {
            Console.WriteLine("My x=" + x);
        }
        public void Show()
        {
            Console.WriteLine(legs);
        }
        public void foo()
        {
            Console.WriteLine("Child");
            base.foo();
        }
        static void Main(string[] args)
        {
            Dog1 d = new Dog1();
            d.Show();
            d.foo();
            Dog1 d1 = new Dog1(5);

        }
    }

    //Method overriding

    class Vehicle
    {
        public virtual void run()
        {
            Console.WriteLine("Vehicle is running.......");
        }
    }
    class Car6 : Vehicle
    {
        public override void run()
        {
            Console.WriteLine("Car is running.......");
            base.run();
        }
    }
    class Truck : Vehicle
    {
        public override void run()
        {
            Console.WriteLine("Truck is running.......");

        }
    }
    class overidingdemo
    {
        static void Main(string[] args)
        {
            /* Car6 c = new Car6();
             c.run();*/
            Vehicle d = new Car6();
            d.run();
        }
    }

    //sealed class

    sealed class Printer
    {
        public void show()
        {
            Console.WriteLine("Printer");
        }
    }
    class Leaser
    {
        public virtual void show()
        {
            Console.WriteLine("Leaser");

        }
    }
    class OfficeJet : Leaser
    {
        public override void show()
        {
            Console.WriteLine("OfficeJet");

        }
    }
    class sealeddemo
    {
        static void Main(string[] args)
        {
            Leaser o = new OfficeJet();
            o.show();


        }
    }
}
