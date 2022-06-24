using System;

namespace Basic.Strings
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "Hello";//using keyword
            String s = "Good Day";//using literal
            String s1 = new string("How are you!");//using new keyword
            int l = s1.Length;
            Console.WriteLine(l);

            string str1 = "Hello";
            string str2 = "Hello";
            /*            Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
                        Console.WriteLine(str1==str2);
                        str1 = str1 + "C#";
                        Console.WriteLine(str1 == str2);
                        Console.WriteLine(str1.GetHashCode() + " " + str2.GetHashCode());*/

            string st = string.Concat(str1, "Pune");
            Console.WriteLine(st + " " + str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(s1 + " " + x);

            int x1 = s1.LastIndexOf('r');
            Console.WriteLine(s1 + " " + x1);

            string s3 = s1.Substring(4);
            Console.WriteLine(s3);

            string s4 = s1.Substring(4, 5);
            Console.WriteLine(s4);

            String s5 = "Java,C3,C,Php";
            string[] ss = s5.Split(",");

            foreach (string sss in ss)
            {
                Console.WriteLine(sss);
            }

            Console.WriteLine(string.Join("   ", "Pune", "   ", "Nashik"));

            string s6 = "      Pune        ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
        }
    }

    //reverse original string

    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            char[] ch = str.ToCharArray();
            /*foreach(char ss in ch)
            {
                Console.WriteLine(ss);
            }*/

            string reverce = "";
            for (int i = 0; i < str.Length; i++)
            {
                reverce = str[i] + reverce;
            }
            Console.WriteLine(reverce);
            /*int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            string st =new string(ch);
            Console.WriteLine(st);*/
        }
    }

    //reverse word of string

    class ReverseWord
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");


            string reverce = "";
            for (int i = 0; i < ch.Length; i++)
            {
                string myword = ch[i];
                string word = "";
                for (int j = myword.Length - 1; j >= 0; j--)
                {
                    word = word + myword[j];
                }
                reverce = reverce + word + " ";
            }
            Console.WriteLine(reverce);
        }
    }

    //count number of words of string

    class CountWords
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");
            Console.WriteLine(ch.Length);
        }
    }

    //print string in pattern formate

    class StringPattern
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


    //reverse word from string except fist and last word

    class ReverseWord1
    {
        static void Main(string[] args)
        {
            string str = "India is my country hhii hhii you";
            string[] ch = str.Split(" ");


            string reverce = "";
            for (int i = 0; i < ch.Length; i++)
            {
                string myword = ch[i];
                string word = "";
                if (i == 0 || i == ch.Length - 1)
                {
                    reverce = reverce + myword + " ";
                }
                else
                {

                    for (int j = myword.Length - 1; j >= 0; j--)
                    {
                        word = word + myword[j];
                    }
                    reverce = reverce + word + " ";
                }

            }
            Console.WriteLine(reverce);
        }
    }

    //reverse word from string except fist and last word

    class DeleteElement
    {
        static void Main(string[] args)
        {
            string str = "India ";
            string str1 = "in";
            string str2 = "";


            for (int i = 0; i < str.Length; i++)
            {
                bool isSame = false;
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str[i] == str1[j])
                    {
                        isSame = true;
                        break;
                    }
                }
                if (isSame == false)
                {
                    str2 = str2 + str[i];
                }

            }

            Console.WriteLine(str2);

        }
    }

    //check

    class StringCheck
    {
        static void Main(string[] args)
        {

            String s = "Hello";
            String s1 = new string("hello");

            Console.WriteLine(s == s1);
            Console.WriteLine(s.Equals(s1));

            int i = s.CompareTo(s1);
            Console.WriteLine(i);
        }
    }

    //display digit of the string and print addition of that
    class DigitString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }
    }

    //Print the the original string by swapping of upper case to lower and lower to upper
    class UpperLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))// or if (ch >= 'A' && ch <= 'Z')
                {
                    //ch = (char)(ch + 32);
                    ch = char.ToLower(ch);
                }
                else if (char.IsLower(ch))// or if (ch >= 'a' && ch <= 'z')
                {
                    //ch = (char)(ch - 32);
                    ch = char.ToUpper(ch);
                }
                str1 = str1 + ch;
            }
            Console.WriteLine("New string:" + str1);
        }
    }


    //check strings are anagram or not
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string str1 = Console.ReadLine();

            string st = str.ToLower();
            string st1 = str1.ToLower();

            char[] ch = st.ToCharArray();
            char[] ch1 = st1.ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch1);

            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine(string.Join(" ", ch1));

            if (ch.Length == ch1.Length)
            {
                bool flag = true;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] != ch1[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                    Console.WriteLine("Strings are Anagram");
                else
                    Console.WriteLine("Strings not are Anagram");

                /*string st2 = new string(ch);
                string st3 = new string(ch1);

                if (st2.Equals(st3))
                {
                    Console.WriteLine("Strings are Anagram");

                }
                else
                    Console.WriteLine("String Not Anagram");*/
            }
            else
                Console.WriteLine("The length of both strings are not same so this are noot anagram strings");

        }
    }
}
