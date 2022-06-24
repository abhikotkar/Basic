using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Arrays
{
    //q.1 Print count of even and odd numbers of array
    class CountEvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int even = 0, odd = 0;

            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The array is:");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    even++;
                else
                    odd++;

            }
            Console.WriteLine();
            Console.WriteLine("Total even numbers are " + even);
            Console.WriteLine("Total odd numbers are " + odd);
        }
    }

    //q.2 predict the output
    class Test
    {
        static int mcc = 100;
        public static int mcCarthy(int n)
        {
            mcc++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100) + " " + mcc);
        }
    }

    //Output:  101 102

    //q.3 Find minimum frequency character from array.
    class LowestFreq
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            char[] a = new char[l];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine("Occurences are:");
            for (int i = 0; i < a.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                            count++;
                    }
                    Console.WriteLine(a[i] + " :" + count);
                }

            }

        }
    }


    //q.7 Remove dublicate elements from the array.
    class Dublicate1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Array without dublicate elements:");
            for (int i = 0; i < a.Length; i++)
            {
                bool isVisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    Console.Write(a[i] + " ");
                }
            }



        }
    }
}
