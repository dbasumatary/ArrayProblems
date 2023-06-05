using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArraySolutionsFirstPart
    {

        //Problem1 : Printing the array
        public static void PrintArray()
        {
            int[] array = new int[10];

            Console.WriteLine("Take user input of 10 elements in array: \n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        //Problem2 : Display array in reverse order
        public static void ReverseDisplay()
        {
            int[] array = new int[100];
            int n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements in the array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values stored into the array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nThe values stored into the array in reverse are: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }

        //Problem3 : Sum of array elements
        public static void SumOfElements()
        {
            int[] array = new int[3];
            int i, sum = 0;

            Console.WriteLine("Take user input of 3 elements in array: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write($"Element {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 3; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("\nThe sum of all elements stored in the array is " + sum);
        }

        //Problem4 : Copy from one array to another
        public static void CopyOneArrayToAnother()
        {
            int[] array = new int[3];
            int[] array2 = new int[3];
            int i;

            Console.WriteLine("Take user input of 3 elements in array: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write($"Element {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values stored in the first array are: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            for (i = 0; i < 3; i++)
            {
                array2[i] = array[i];
            }

            Console.Write("\nThe values copied into the second array are: ");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
        }

        //Problem5 : Count duplicate elements
        public static void CountDuplicate()
        {
            int[] arr = new int[100];
            int i, j, num, count = 0;

            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Find all duplicate elements in array
            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("\nThe total number of duplicate elements found in array: " + count);
            Console.WriteLine();
        }
    }
}
