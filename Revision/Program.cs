using System;

namespace Basic.Revision
{
    class AvgOfEvenDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                if (r % 2 == 0)
                {
                    sum = sum + r;
                    count++;
                }
                n = n / 10;

            }
            Console.WriteLine("Total even digits are " + count);
            Console.WriteLine();
            Console.WriteLine("Everage is " + sum / count);
        }
    }

    class SortHalfArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The original array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length / 2; i++)
            {

                for (int j = i + 1; j < arr.Length / 2; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = arr.Length / 2; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array is");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
