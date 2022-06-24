using System;

namespace Basic.OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //method class  and create object
    class Employee
    {
        int empid;
        string name;
        int salary;

        public void emp()
        {
            empid = 111;
            name = "Aman";
            salary = 78000;
        }

        public void display()
        {
            Console.WriteLine(empid + " " + name + " " + salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.emp();
            e.display();
        }
    }

    class Car
    {
        int modelno;
        string carname;
        string carcolor;
        int prize;

        public void cardemo()
        {
            Console.WriteLine("Enter car model no: ");
            modelno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter car name: ");
            carname = Console.ReadLine();
            Console.WriteLine("Enter car color: ");
            carcolor = Console.ReadLine();
            Console.WriteLine("Enter car prize: ");
            prize = int.Parse(Console.ReadLine());
        }

        public void display1()
        {
            Console.WriteLine();
            Console.WriteLine("Model no:" + modelno);
            Console.WriteLine("Car name:" + carname);
            Console.WriteLine("Car color:" + carcolor);
            Console.WriteLine("Prize:" + prize);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            for (int i = 1; i <= 2; i++)
            {
                c.cardemo();
                c.display1();
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        int studid;
        string studname;
        int english;
        int math;
        int science;
        float perc;

        public void studdemo()
        {
            Console.WriteLine("Enter student id: ");
            studid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            studname = Console.ReadLine();
            Console.WriteLine("Enter marks of English: ");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of Math: ");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks of Science: ");
            science = int.Parse(Console.ReadLine());
        }
        public void percentage()
        {
            perc = ((english + math + science) / 3);
        }
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("Student ID:" + studid);
            Console.WriteLine("Student Name:" + studname);
            Console.WriteLine("English Marks:" + english);
            Console.WriteLine("Math Marks:" + math);
            Console.WriteLine("Science Marks:" + science);
            Console.WriteLine("Percentage:" + perc);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.studdemo();
            s.percentage();
            s.display();
            Console.WriteLine();

        }
    }

    //use of this keyword these are 3 uses of this keyword also use of constructor
    class Car1
    {
        int model_no;
        string name;
        string color;
        int prize;
        string cname;

        public void input(int model_no, string name, string color, int prize)
        {
            this.model_no = model_no;
            this.name = name;
            this.color = color;
            this.prize = prize;
        }

        void show()
        {
            this.input(102, "audi", "white", 3000000);
            Console.WriteLine(model_no);
            Console.WriteLine(name);
            Console.WriteLine(color);
            Console.WriteLine(prize);
        }

        public Car1(string cname)
        {
            this.cname = cname;
            display();
        }

        public void display()
        {
            Console.WriteLine(cname);
        }

        public Car1() : this("Breszza")
        {
            Console.WriteLine("I am the default constructor.");
        }
        static void Main(string[] args)
        {
            Car1 c1 = new Car1();

            c1.show();
        }
    }

    class Bank
    {
        int accno;
        string acctype;
        string custname;
        int balance;

        public void input()
        {
            Console.WriteLine("Enter account number:");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type:");
            acctype = Console.ReadLine();
            Console.WriteLine("Enter customer name:");
            custname = Console.ReadLine();
            Console.WriteLine("Enter account balance:");
            balance = int.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine();
            Console.WriteLine("Account number:" + accno);
            Console.WriteLine("Account type:" + acctype);
            Console.WriteLine("Customer name:" + custname);
            Console.WriteLine("Balance:" + balance);
        }

        public void withdrow()
        {
            Console.WriteLine("Enter amount you can withdrow:");
            int w = int.Parse(Console.ReadLine());
            balance = balance - w;
            display();
        }

        public void deposit()
        {
            Console.WriteLine("Enter amount you can deposit:");
            int d = int.Parse(Console.ReadLine());
            balance = balance + d;
            display();
        }

        public void display()
        {
            Console.WriteLine("The updated available balance is " + balance);
        }

        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.input();
            b.show();
            Console.WriteLine("Which operation you can perform w or d:");
            int op = char.Parse(Console.ReadLine());
            if (op == 'w')
                b.withdrow();
            else if (op == 'd')
                b.deposit();
            else
                Console.WriteLine("You entered wrong choice");
        }
    }


    class StudentDetails
    {
        int id;
        string name;
        int marks;

        public void student()
        {
            Console.WriteLine();
            Console.WriteLine("Enter student ID: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter student marks: ");
            marks = int.Parse(Console.ReadLine());
        }

        public void display1()
        {
            Console.WriteLine();
            Console.WriteLine("Student Id:" + id);
            Console.WriteLine("Student name:" + name);
            Console.WriteLine("Student Marks:" + marks);
        }
        static void Main(string[] args)
        {
            StudentDetails s = new StudentDetails();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("----------------Enter " + i + " student details-------------");
                s.student();

                Console.WriteLine("----------------Student " + i + " Details-------------------");
                s.display1();
                Console.WriteLine();
            }
        }
    }



    //Polymorphisn 1.Compile time polymorphism
    //Method Overloading.

    class ShowDetails
    {
        void Show()
        {
            Console.WriteLine("Show method");
        }

        void Show(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, float b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, int b, int c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Main(string[] args)
        {
            ShowDetails s = new ShowDetails();
            s.Show();
            s.Show(4, 5);
            s.Show(4, 2.5f);
            s.Show(4, 5, 6);
        }
    }

    //Overloading for calculate arrithmetic operations

    class Arrithmetic
    {

        void calculate(int a, int b, int c)
        {

            Console.WriteLine("Addition is:" + (a + b + c));
        }

        void calculate(int a, int b)
        {

            Console.WriteLine("Substraction is:" + (a - b));
        }

        void calculate(int a, double b)
        {

            Console.WriteLine("Multiplication is:" + (a * b));
        }

        void calculate(double a, int b)
        {

            Console.WriteLine("Division is:" + (a / b));
        }

        static void Main(string[] args)
        {
            Arrithmetic a = new Arrithmetic();
            a.calculate(1, 2, 3);
            a.calculate(2, 1);
            a.calculate(5, 5);
            a.calculate(50, 5);
        }
    }

    //Overloading for calculate area of circle,rectangle,triangle,square.

    class Areas
    {

        void area(float r)
        {

            Console.WriteLine("Area of circle is:" + (3.14 * r * r));
        }

        void area(int a, int b)
        {

            Console.WriteLine("Area of rectangle is:" + (a * b));
        }

        void area(int b, float h)
        {

            Console.WriteLine("Area of triangle is:" + (0.5 * b * h));
        }

        void area(int s)
        {

            Console.WriteLine("Area of square is:" + (s * s));
        }

        static void Main(string[] args)
        {
            Areas a = new Areas();
            Console.WriteLine("Enter radius for calculate area of circle:");
            float r = float.Parse(Console.ReadLine());
            a.area(r);

            Console.WriteLine("Enter length and width for calculate area of rectangle:");
            int ab = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a.area(ab, b);

            Console.WriteLine("Enter base and height for calculate area of triangle:");
            int x = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            a.area(x, y);

            Console.WriteLine("Enter side for calculate area of square:");
            int z = int.Parse(Console.ReadLine());
            a.area(z);
        }
    }

    //constructor Overloading for calculate area of circle,rectangle,triangle,square.

    class Areas1
    {

        public Areas1(float r) : this(4f, 5f)
        {

            Console.WriteLine("Area of circle is:" + (3.14 * r * r));
        }

        public Areas1(float a, float b) : this(6, 5f)
        {

            Console.WriteLine("Area of rectangle is:" + (a * b));
        }

        public Areas1(int b, float h) : this(6)
        {

            Console.WriteLine("Area of triangle is:" + (0.5 * b * h));
        }

        public Areas1(int a)
        {

            Console.WriteLine("Area of square is:" + (a * a));
        }


        static void Main(string[] args)
        {
            Areas1 a = new Areas1(3f);

        }
    }
}
