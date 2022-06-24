using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Strings
{
    class Stringbuilddemo
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            StringBuilder sb = new StringBuilder("Hello");
            String s1 = "Hii";
            StringBuilder sp = new StringBuilder(s1);
            Console.WriteLine(sp);

            StringBuilder sp1 = new StringBuilder("Hii");
            Console.WriteLine(sp1);

            Console.WriteLine(sp.Equals(sp1));
            Console.WriteLine(sp == sp1);//it check also memory location

            sp.Append(" How are");
            Console.WriteLine(sp);

            sp.AppendLine(" you?");
            Console.WriteLine(sp);

            sp.Insert(4, "Hello ");
            Console.WriteLine(sp);

            sp.Remove(4, 6);
            Console.WriteLine(sp);

            for (int i = 0; i < sp.Length; i++)
            {
                Console.WriteLine(sp[i]);
            }
        }
    }

    class Stringbuild
    {
        static void Main(string[] args)
        {
            string str = "nitin";
            string temp = str;
            StringBuilder sb = new StringBuilder(str);




            string reverce = "";
            for (int i = 0; i < sb.Length; i++)
            {
                reverce = sb[i] + reverce;
            }
            Console.WriteLine(reverce);
            if (reverce == temp)
                Console.WriteLine("String is palindrome.");
            else
                Console.WriteLine("String is not palindrome");
        }
    }
}
