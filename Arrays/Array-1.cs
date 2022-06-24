using System;

namespace Basic.Arrays
{
    //Array Output.
    class Display
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    //Initialize array and display.
    class Display1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("The array is:");
            /* for (int i = 0; i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }*/


            /* foreach(int x in a)
               {
                   Console.WriteLine(x);
               }*/

            //a.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine(string.Join(" ", a));
        }
    }

    //Print reverse array.
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];

            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The array is:");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    //print sum of array elements
    class SumOfElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int sum = 0;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i]; ;
            }
            Console.WriteLine("The array sum is: " + sum);
        }
    }

    //Print even elements of the array.
    class EvenElements
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
            Console.WriteLine("The even elements are:");
            foreach (int x in a)
            {
                if (x % 2 == 0)
                    Console.WriteLine(x);
            }
        }
    }

    //Print prime elements of the array.
    class PrimeElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            bool isprime = true;
            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The prime elements are:");
            foreach (int x in a)
            {
                isprime = true;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                    Console.WriteLine(x);
            }
        }
    }

    //Print odd position elements of the array.
    class OddPosition
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
            Console.WriteLine("The odd position elements are:");
            for (int i = 0; i < a.Length; i = i + 2)
            {


                Console.WriteLine(a[i]);
            }
        }
    }

    //Print alternate elements of the array.
    class Alternate
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
            Console.WriteLine("The alternate elements are:");
            for (int i = 1; i < a.Length; i = i + 2)
            {


                Console.WriteLine(a[i]);
            }
        }
    }

    //Print sum of prime elements of the array.
    class PrimeSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int sum = 0;
            bool isprime = true;
            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The prime elements are:");
            foreach (int x in a)
            {
                isprime = true;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                    sum = sum + x;
            }
            Console.WriteLine("The sum of prime numbers is: " + sum);
        }
    }

    //create character original array to reverse array.
    class CharReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            char[] a = new char[l];
            char temp;
            int j = a.Length - 1;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine("The array is:");
            Console.WriteLine(string.Join(" ", a));
        }
    }

    //create original array to reverse array.
    class IntReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int temp, j = a.Length - 1;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    //display max number of the array.
    class MaxElement
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
            int max = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("The maximum element is " + max);
        }
    }

    //display max number of the array.
    class MinElement
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
            int min = a[1];
            foreach (int x in a)
            {
                if (x < min)
                    min = x;
            }
            Console.WriteLine("The minimum element is " + min);
        }
    }


    //display occurences of each element of array.
    class Occurences
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

    //find given number occurences from the elements of array.
    class Occurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int count = 0;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enetr the number to find occurence:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                    count++;
            }
            Console.WriteLine("Occurences of " + n + " are " + count);
        }
    }

    //display unique elements from the array.
    class Unique
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
                    if (count == 1)
                        Console.WriteLine(a[i]);
                }

            }

        }
    }

    //display Dublicate elements from the array.
    class Dublicate
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
                    if (count == 1)
                        Console.WriteLine(a[i]);
                }

            }

        }
    }

    //merge two array into third array
    class Mearge
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 1, 2 };
            int[] b = { 7, 8, 9, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < b.Length; j++)
            {
                c[i] = b[j];
                i++;
            }
            /*foreach(int x in c)
            {
                Console.WriteLine(x);
            }*/
            Console.WriteLine(string.Join(" ", c));
        }
    }

    //Print unique elements of array after mearging
    class UniqueArray
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 2, 6, 1, 4, 2 };
            int[] b = { 7, 8, 9, 5, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < b.Length; j++)
            {
                c[i] = b[j];
                i++;
            }
            for (i = 0; i < c.Length; i++)
            {
                bool isVisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[k] == c[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    Console.Write(c[i] + " ");
                }
            }
            Console.WriteLine();
            /*foreach(int x in c)
            {
                Console.WriteLine(x);
            }*/
            Console.WriteLine(string.Join(" ", c));
        }
    }

    //mearge two arrays into alternate position
    class MeargeAlternate
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 2, 6, 1, 4 };
            int[] b = { 7, 8, 9, 5, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i = 0, j = 0;
            for (int k = 0; k <= c.Length; k++)
            {
                if ((k == 0 || k % 2 == 0) && i < a.Length)
                {
                    c[k] = a[i];
                    i++;
                }
                else if ((k % 2 == 1) && j < b.Length)
                {
                    c[k] = b[j];
                    j++;
                }



            }
            Console.WriteLine(string.Join(" ", c));
        }
    }


    //sort array in accending array.
    class SortAssending
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }


    //sort array in Descending array.
    class SortDescending
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }


    //sort integer array in accending array.
    class SortAssending1
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }

    //sort integer array in deccending array.
    class SortDescending1
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }

    //Array to method.

    class ArraytoMethod
    {
        int[] Dosort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])

                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 2, 8, 5, 0 };
            ArraytoMethod b = new ArraytoMethod();
            int[] newArray = b.Dosort(a);
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
