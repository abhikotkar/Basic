using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    public interface IPrintable
    {
        static int y;
        void print();
    }
    public interface IMovable
    {
        static int x;
        void show();


        public static void myMethod()
        {
            Console.WriteLine("It is static interface method");
        }

        void foo()
        {
            Console.WriteLine("Its foo method");
        }
    }

    class Cars : IMovable, IPrintable
    {
        public void show()
        {
            IMovable.x = 400;
            Console.WriteLine("My interface method " + IMovable.x);
        }
        public void print()
        {
            IPrintable.y = 500;
            Console.WriteLine("My interface method " + IPrintable.y);
            Console.WriteLine(IMovable.x + IPrintable.y);
        }
    }

    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IMovable i = new Cars();
            i.show();
            IMovable.myMethod();
            i.foo();

            IPrintable p = new Cars();
            p.print();
        }
    }



    interface Addable
    {
        static int x = 100;
    }
    abstract class Addition
    {
        public int y = 500;
        public abstract void Add();
    }
    class Sum : Addition, Addable
    {
        public override void Add()
        {
            Console.WriteLine(y + Addable.x);
        }

    }

    class InterfaceDemo2
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            s.Add();


        }
    }


    //Example interface and abstract class

    interface Drawable
    {
        void drow();
    }
    abstract class Shape
    {
        public abstract void Fill();
    }
    class Circles : Shape, Drawable
    {
        public override void Fill()
        {
            Console.WriteLine("Circle is fill with red color");
        }
        public void drow()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            Circles c = new Circles();
            c.Fill();
            c.drow();

        }
    }
}
