using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Arrays
{
    class TwoDArray1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //create 2D array

    class TwoDArrayCreate
    {
        static void Main(string[] args)
        {
            // int[,] a = { { 4, 5, 6 }, { 7, 5, 9 }, { 8, 6, 2 } };

            int[,] a = new int[2, 2];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************************");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    //row wise sum matrix
    class Sum
    {
        static void Main(string[] args)
        {

            int[,] a = { { 4, 5, 6 }, { 7, 5, 9 }, { 8, 6, 2 } };

            int sum;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write(" = " + sum);
                Console.WriteLine();
            }
        }
    }

    //pattern of array
    class ArrayPattern
    {
        static void Main(string[] args)
        {

            int[,] a = new int[4, 4];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                        Console.Write(a[i, j]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }

    //addition of two matrix
    class ArrayAddition
    {
        static void Main(string[] args)
        {

            int[,] a = new int[3, 3];
            Console.WriteLine("Enter first Array elements:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int[,] b = new int[3, 3];
            Console.WriteLine("Enter second Array elements:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************************");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************************");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write((a[i, j] + b[i, j]) + " ");
                }
                Console.WriteLine();
            }

        }
    }

    //column wise sum matrix
    class ColumnSum
    {
        static void Main(string[] args)
        {

            int[,] a = { { 4, 5, 6 }, { 7, 5, 9 }, { 8, 6, 2 } };

            int sum1 = 0, sum2 = 0, sum3 = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        sum1 = sum1 + a[i, j];
                        Console.Write(a[i, j] + " ");
                    }
                    else if (j == 1)
                    {
                        sum2 = sum2 + a[i, j];
                        Console.Write(a[i, j] + " ");
                    }
                    else if (j == 2)
                    {
                        sum3 = sum3 + a[i, j];
                        Console.Write(a[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine(" =  =  = ");
            Console.WriteLine(sum1 + " " + sum2 + " " + sum3);
        }
    }

    //row wise average of matrix
    class RowAverage
    {
        static void Main(string[] args)
        {

            int[,] a = { { 4, 5, 6 }, { 7, 5, 9 }, { 8, 6, 2 } };

            int sum;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write(" = " + sum / a.GetLength(1));
                Console.WriteLine();
            }
        }
    }


    //pattern of print outer element of array
    class OuterArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many rows and columns you want");
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] a = new int[r, c];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                        Console.Write(a[i, j]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
