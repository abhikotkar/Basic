using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.OOPS
{
    //Encapsulation means property writing and has a relationship means contentment writing.

    //Encapsulation 
    //It is the wrapping of data.
    class Encapsulation1
    {
        private int id;
        private string name;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }

    class EmpInfo
    {
        static void Main(string[] args)
        {
            Encapsulation1 e = new Encapsulation1();
            e.Id = 120;
            e.Name = "Abhi";
            e.Salary = 200000;
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);
        }
    }

    class Student1
    {
        private int id;
        private string name;
        private double per;

        public int Id
        {
            get;
            set;
        }
        public string Nme
        {
            get;
            set;
        }
        public int Per
        {
            get;
            set;
        }
    }

    class StudInfo
    {
        static void Main(string[] args)
        {
            Encapsulation1 e = new Encapsulation1();
            e.Id = 102;
            e.Name = "amit";
            e.Salary = 202412;
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);
        }
    }

    class Car2
    {
        private int modelno;
        private string name;
        private string color;
        private int prize;

        public int Modelno { get => modelno; set => modelno = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Prize { get => prize; set => prize = value; }
    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car2 c = new Car2();
            c.Modelno = 205;
            c.Name = "Scorpio";
            c.Color = "Black";
            c.Prize = 3500000;
            Console.WriteLine(c.Modelno + " " + c.Name + " " + c.Color + " " + c.Prize);

        }
    }

    class Student2
    {
        private int id;
        private string name;
        private double per;
        private bool placed;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Per { get => per; set => per = value; }
        public bool Placed { get => placed; set => placed = value; }
    }

    class Stud2Info
    {
        static void Main(string[] args)
        {
            Student2 s = new Student2();
            s.Id = 205;
            s.Name = "Abhi";
            s.Per = 68;
            s.Placed = false;
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Per + " " + (s.Placed == true ? "Placed" : "Not Placed"));
        }
    }



    //has a relationship     means employee has a department
    //person has a address
    //car has a engine 
    //means obbject has a objects

    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode, string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        public Person(int id, string name, Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + adr.pincode + " " + adr.city);
        }
        static void Main(string[] args)
        {
            Address a = new Address(422613, "Pune");
            Person p = new Person(654, "Abhi", a);
            p.display();
        }
    }

    //has a relationship     using properties means encapsulation


    class Department
    {
        private int deptid;
        private string name;

        public int Deptid { get => deptid; set => deptid = value; }
        public string Name { get => name; set => name = value; }
    }
    class Employee1
    {
        private int id;
        private string name;
        private Department dept;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Department Dept { get => dept; set => dept = value; }

        static void Main(string[] args)
        {
            /*Department d = new Department();
            d.Deptid = 205;
            d.Name = "HR";
            Employee1 e = new Employee1();
            e.Id = 365;
            e.Name = "Rutu";
            Console.WriteLine(e.Id+" "+e.Name+" "+d.Deptid+" "+d.Name);
*/
            Employee1 e = new Employee1();
            e.Id = 365;
            e.Name = "Rutu";
            e.Dept = new Department();
            e.Dept.Deptid = 562;
            e.Dept.Name = "Finance";
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Dept.Deptid + " " + e.Dept.Name);

        }
    }

    //has a relationship     using properties


    class Address1
    {
        private int pincodd;
        private string city;

        public int Pincode { get => pincodd; set => pincodd = value; }
        public string City { get => city; set => city = value; }
    }
    class Person1
    {
        private int id;
        private string name;
        private Address1 adr;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Address1 Adr { get => adr; set => adr = value; }

        static void Main(string[] args)
        {

            Person1 p = new Person1();
            p.Id = 365;
            p.Name = "Rutu";
            p.Adr = new Address1();
            p.Adr.Pincode = 562;
            p.Adr.City = "Pune";
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.Pincode + " " + p.Adr.City);
        }
    }

    class Department1
    {
        public int id;
        public string name;

        public Department1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class Employee2
    {
        int id;
        string name;
        Department1 dept;

        public Employee2(int id, string name, Department1 dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + dept.id + " " + dept.name);
        }
        static void Main(string[] args)
        {
            Department1 d = new Department1(422613, "HR");
            Employee2 e = new Employee2(654, "Abhi", d);
            e.display();
        }
    }

    class Engine
    {
        public int emodelno;
        public string type;

        public Engine(int emodelno, string type)
        {
            this.emodelno = emodelno;
            this.type = type;
        }
    }
    class Car3
    {
        string name;
        string color;
        int prize;
        Engine e;

        public Car3(string name, string color, int prize, Engine e)
        {
            this.name = name;
            this.color = color;
            this.prize = prize;
            this.e = e;
        }
        void display()
        {
            Console.WriteLine(name + " " + color + " " + prize + " " + e.emodelno + " " + e.type);
        }
        static void Main(string[] args)
        {
            Engine e = new Engine(422613, "Petrol");
            Car3 c = new Car3("Brezza", "White", 260000, e);
            c.display();
        }
    }

    //Has  a relationship using encapsulation 
    class Engine1
    {
        private int emodelno;
        private string type;

        public int Emodelno { get => emodelno; set => emodelno = value; }
        public string Type { get => type; set => type = value; }
    }

    class Car4
    {
        private string name;
        private string color;
        private int prize;
        private Engine eng;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Prize { get => prize; set => prize = value; }
        internal Engine Eng { get => eng; set => eng = value; }

        static void Main(string[] args)
        {
            Car4 c = new Car4();
            c.Name = "Ertiga";
            c.Color = "White";
            c.Prize = 6562625;
            Engine1 e = new Engine1();
            e.Emodelno = 645;
            e.Type = "Diasel";
            Console.WriteLine(c.Name + " " + c.Color + " " + c.Prize + " " + e.Emodelno + " " + e.Type);
        }
    }

    //contentment writting of two objects

    class SubEngine
    {
        string cleanupdate;
        public SubEngine(string cleanupdate)
        {
            this.cleanupdate = cleanupdate;
        }

        public void displaySubEngine()
        {
            Console.WriteLine(cleanupdate);
        }
    }

    class Engine2
    {
        string type;
        SubEngine sub;

        public Engine2(string type, SubEngine sub)
        {
            this.type = type;
            this.sub = sub;
        }

        public void displayengine()
        {
            Console.WriteLine(type + " ");
            sub.displaySubEngine();
        }
    }

    class Car5
    {
        int modelno;
        string name;
        Engine2 e;

        Car5(int modelno, string name, Engine2 e)
        {
            this.modelno = modelno;
            this.name = name;
            this.e = e;
        }

        void show()
        {
            Console.WriteLine(modelno + " " + name + " ");
            e.displayengine();
        }

        static void Main(string[] args)
        {
            Car5 c = new Car5(102, "BMW", (new Engine2("Petrol", new SubEngine("06/06/2022"))));
            c.show();
        }
    }

    //example
    class Nib
    {
        internal string meterial_type;
        public Nib(string meterial)
        {
            meterial_type = meterial;
        }
    }

    class Pen
    {
        internal int length;
        internal string color;
        internal int prize;
        internal Nib nib;

        public Pen(int length, string color, int prize, Nib nib)
        {
            this.length = length;
            this.color = color;
            this.prize = prize;
            this.nib = nib;
        }

    }

    class Brand
    {
        string name;
        Pen p;

        Brand(string name, Pen p)
        {
            this.name = name;
            this.p = p;
        }

        void show()
        {
            Console.WriteLine(name + " " + p.length + " " + p.color + " " + p.prize + " " + p.nib.meterial_type);

        }

        static void Main(string[] args)
        {
            Brand b = new Brand("Parker", new Pen(5, "Purple", 100, new Nib("Metal")));
            b.show();
        }
    }

    //using get set method

    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }
    }

    class Mydepartment
    {
        private int did;
        private string dname;
        public int Did
        {
            get;
            set;
        }
        public string Dname
        {
            get;
            set;
        }
    }

    class Myemployee
    {
        private int id;
        private string name;
        Mydepartment dept;
        Mydate dt;
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Mydepartment Dept
        {
            get;
            set;
        }
        public Mydate Dt
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Myemployee m = new Myemployee();
            m.Id = 201;
            m.Name = "Amit";
            m.Dept = new Mydepartment();

            m.Dept.Did = 450;
            m.Dept.Dname = "HR";

            m.Dt = new Mydate();
            m.Dt.Dd = 02;
            m.Dt.Mm = 06;
            m.Dt.Yy = 2022;

            Console.WriteLine(m.Id + " " + m.Name + " " + m.Dept.Did + " " + m.Dept.Dname + " " + m.Dt.Dd + " " + m.Dt.Mm + " " + m.Dt.Yy);

        }
    }

    //using get set method shiptment contentment

    //Mydate class declare before program

    class Order1
    {
        private int oid;
        private string custname;
        private int prize;
        private string city;
        public int Oid
        {
            get;
            set;
        }
        public string Custname
        {
            get;
            set;
        }
        public int Prize
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
    }

    class ShipmentDiary
    {
        private string sdiary;
        Order1 ord;
        Mydate dt;
        public string Sdiary
        {
            get;
            set;
        }
        public Order1 Ord
        {
            get;
            set;
        }
        public Mydate Dt
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            ShipmentDiary s = new ShipmentDiary();
            s.Sdiary = "Book";
            s.Ord = new Order1();
            s.Ord.Oid = 230;
            s.Ord.Custname = "Amey";
            s.Ord.Prize = 1653;
            s.Ord.City = "Pune";

            s.Dt = new Mydate();
            s.Dt.Dd = 02;
            s.Dt.Mm = 06;
            s.Dt.Yy = 2022;

            Console.WriteLine(s.Sdiary + " " + s.Ord.Oid + " " + s.Ord.Custname + " " + s.Ord.Prize + " " + s.Ord.City + " " + s.Dt.Dd + " " + s.Dt.Mm + " " + s.Dt.Yy);

        }
    }
}
