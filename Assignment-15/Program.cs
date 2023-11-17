using System;
using System.Collections.Generic;


namespace Assignment_15
{
    internal class Program
    {
        // Bubble Sort algorithm for sorting in descending order
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noSwap = 0;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                       
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        noSwap++;
                    }
                }
                if (!swapped)
                { break; }
            }
        }

        // Method to check if the array is sorted correctly
        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                    return false;
            }
            return true;
        }

        // Binary Search algorithm
        static int BinarySearch(int[] arr, int sItem)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the Item is present at the middle
                if (arr[mid] == sItem)
                { 
                   return mid;
                 }

                // If Item is greater, ignore the left half
                else if (arr[mid] < sItem)
                    left = mid + 1;

                // If Item is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // Item is not present in the array
            return -1;
        }

        // Method to generate a random array of integers
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 100); // Adjust the range as needed
            }

            return arr;
        }

        // Method to display the elements of an array
        static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Generate a random array
            int[] array = GenerateRandomArray(10);

            // Display the original array
            Console.WriteLine("Original Array:");
            DisplayArray(array);

            // Bubble Sort in descending order
            BubbleSort(array);

            // Display the sorted array
            Console.WriteLine("\nSorted Array (Descending Order):");
            DisplayArray(array);

            // Check if the array is sorted correctly
            Console.WriteLine("\nIs the array sorted correctly? " + IsSorted(array));

            // Perform Binary Search
            int searchValue = 48; // Change this value as needed
            int result = BinarySearch(array, searchValue);

            // Display the result of Binary Search
            if (result == -1)
                Console.WriteLine($"\n{searchValue} not found in the array.");
            else
                Console.WriteLine($"\n{searchValue} found at index {result}.");

            Console.ReadLine();
        }
    }
}
