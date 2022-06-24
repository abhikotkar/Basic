using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Basic_1
{
    //boolean

    class bool1
    {
        static void Main(string[] args)
        {
            int i = -10;
            for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i++)) ;
        }
    }


    //example od dowhile

    class dowhile
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i > 10);
        }
    }

    // menudriven of simple calculator
    class menudriven
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter any two numbers:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division");
                Console.WriteLine("Enter choice which operation you can perform:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The addition is " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("The substraction is " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("The multiplication is " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("The division is " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.WriteLine("Do you want to continue ");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
    }

    // menudriven of calculate area of circle rectangle triangle and square
    class menudriven1
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {

                Console.WriteLine("1.Area of circle \n 2.Area of rectangle \n 3.Area of triangle \n 4.Area of square");
                Console.WriteLine("Enter choice which operation you can perform:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius of circle:");
                        int rad = int.Parse(Console.ReadLine());
                        Console.WriteLine("The area of circle is  " + (3.14 * rad * rad));
                        break;
                    case 2:
                        Console.WriteLine("Enter the length and width of rectangle:");
                        int len = int.Parse(Console.ReadLine());
                        int wdth = int.Parse(Console.ReadLine());
                        Console.WriteLine("The area of rectangle is  " + (len * wdth));
                        break;
                    case 3:
                        Console.WriteLine("Enter the base and height of triangle:");
                        int b = int.Parse(Console.ReadLine());
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine("The area of triangle is  " + (0.5 * b * h));
                        break;
                    case 4:
                        Console.WriteLine("Enter the side of square:");
                        int side = int.Parse(Console.ReadLine());
                        Console.WriteLine("The area of square is  " + (side * side));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.WriteLine("Do you want to continue ");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
    }

    //sum the factorial of upto 5 factorial

    class factorial2
    {
        static void Main(string[] args)
        {
            int sum = 0, fact;
            for (int i = 1; i <= 5; i++)
            {
                fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                sum += fact;
            }

            Console.WriteLine("The sum is " + sum);
        }
    }

    //tables between 1 to 5

    class table1to5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The table of " + i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i * j);
                }

            }


        }
    }

    /*    * * * *
          * * * *
          * * * *
          * * * *   */

    class pattern1
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }



    /*         * 
               * * 
               * * * 
               * * * *   */

    class pattern2
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }

    /*         * * * *
               * * * 
               * * 
               *         */

    class pattern3
    {
        static void Main(string[] args)
        {

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }

    /*        1
              2 2
              3 3 3
              4 4 4 4     */

    class pattern4
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }
    }

    /*        1
              1 2
              1 2 3
              1 2 3 4     */

    class pattern5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }


    /*       1 2 3 4
             1 2 3
             1 2
             1     */

    class pattern6
    {
        static void Main(string[] args)
        {

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }



    /*      4 3 2 1
            4 3 2
            4 3
            4     */

    class pattern7
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }


    /*      1 
            2 3
            4 5 6
            7 8 9 10     */

    class pattern8
    {
        static void Main(string[] args)
        {
            int count = 1;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + count);
                    count++;
                }

                Console.WriteLine();
            }
        }
    }


    /*     * * * *
           *     *
           *     *
           * * * *     */

    class pattern9
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }

    //number is triometric or not

    class triomorphic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n * n;
            int r = m % 10;
            if (r == n)
                Console.WriteLine("The given number is triomorphic");
            else
                Console.WriteLine("The given number is not triomorphic");

        }
    }

    //check number is disarium or not

    class Disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int temp1 = n;
            int temp = n, rem = 0, rem1, mul, sum = 0;
            while (temp > 0)
            {
                rem++;
                temp = temp / 10;
            }
            while (rem >= 1)
            {
                rem1 = temp1 % 10;
                mul = 1;
                for (int i = 1; i <= rem; i++)
                {
                    mul = mul * rem1;
                }
                temp1 = temp1 / 10;
                sum = sum + mul;
                rem--;
            }
            Console.WriteLine(sum);
            if (sum == n)
                Console.WriteLine("The number is disarium");
            else
                Console.WriteLine("The number is not disarium");


        }
    }

    //number is autometric or not

    class automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            int temp = n, rem = 0;
            while (temp > 0)
            {
                rem++;
                temp = temp / 10;
            }
            int power = 1;
            while (rem > 0)
            {
                power = power * 10;
                rem--;
            }
            int end = m % power;

            if (end == n)
                Console.WriteLine("The given number is automorphic");
            else
                Console.WriteLine("The given number is not automorphic");

        }
    }

    //number is karpraker or not

    class cartbreaker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            int rem = 0, sum = 0;
            while (m > 0)
            {
                rem = m % 10;
                sum = sum + rem;
                m = m / 10;
            }

            if (sum == n)
                Console.WriteLine("The given number is cartbreaker");
            else
                Console.WriteLine("The given number is not cartbreaker");

        }
    }


    //print prime numbers between 1 to 10.
    class prime1
    {
        static void Main(string[] args)
        {
            bool istrue;
            int i, j;
            Console.WriteLine("The prime numbers beetween 1 to 10 are:");
            for (i = 1; i <= 50; i++)
            {
                istrue = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        istrue = false;
                        break;

                    }
                }
                if (istrue == true)
                    Console.WriteLine(i);


            }
        }
    }


    class debug
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);
        }
    }


    /*     * 
           * *
           *   *
           * * * *     */

    class pattern10
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i == 4 || i == j || j == 1)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }


    /*             *
                  * *
                 * * *
                * * * *     */

    class pattern11
    {
        static void Main(string[] args)
        {
            int max = 4;
            int temp = max;
            for (int i = 0; i < temp; i++)
            {

                for (int j = 1; j <= 7; j++)
                {
                    if (j >= max && j <= (max + (2 * i)))
                    {
                        if (i == 0 || i % 2 == 0)
                        {
                            if (j % 2 == 0)
                                Console.Write(" *");
                            else
                                Console.Write("  ");
                        }
                        else
                        {
                            if (j % 2 == 1)
                                Console.Write(" *");
                            else
                                Console.Write("  ");
                        }
                    }
                    else
                        Console.Write("  ");

                }
                max--;
                Console.WriteLine();


            }
        }
    }

    /*            1 0 1 0 1
                  0 1 0 1 0
                  1 0 1 0 1
                  0 1 0 1 0
                  1 0 1 0 1    */

    class pattern12
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 2; i <= 6; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 1)
                            Console.Write("1");
                        else
                            Console.Write("0");
                    }
                    else
                    {
                        if (j % 2 == 1)
                            Console.Write("0");
                        else
                            Console.Write("1");

                    }
                }
                Console.WriteLine();
            }




        }
    }


    /*             1
                  333
                 55555
                7777777     */

    class pattern13
    {
        static void Main(string[] args)
        {
            int max = 4;
            int temp = max;
            int k = 1;
            for (int i = 0; i < temp; i++)
            {

                for (int j = 1; j <= 7; j++)
                {


                    if (j >= max && j <= (max + (2 * i)))
                        Console.Write(k);
                    else
                        Console.Write(" ");


                }
                max--;
                Console.WriteLine();
                k += 2;


            }
        }
    }

    /*           1
                 1 0
                 1 0 1
                 1 0 1 0
                 1 0 1 0 1   */

    class pattern14
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 1)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }




        }
    }
}
