using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                // Initialize an empty list to store the missing numbers
                List<int> flist = new List<int>();

                // Convert the input array to a list for easier manipulation
                List<int> nums1List = nums.ToList();

                // Loop through the numbers starting from the minimum number in the list to the count of the list
                for (int i = nums1List.Min(); i < nums1List.Count; i++)
                {
                    // If the number is present in the list, skip it (no need to add it to the missing list)
                    if (nums1List.Contains(i))
                    {
                        continue;
                    }
                    else
                    {
                        // If the number is missing from the list, add it to the missing numbers list
                        flist.Add(i);
                    }
                }
                // Return the list of missing numbers
                return flist; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                // Convert the input array into a list for easier manipulation
                List<int> numsp = nums.ToList();

                // Initialize two lists to separate even and odd numbers
                List<int> listEven = new List<int>();
                List<int> listOdd = new List<int>();

                // Iterate over each number in the array
                foreach (int i in numsp)
                {
                    // Check if the number is even
                    if (i % 2 == 0)
                    {
                        listEven.Add(i); // Add even numbers to the even list
                    }
                    else
                    {
                        listOdd.Add(i); // Add odd numbers to the odd list
                    }
                }
                // Sort both the even and odd lists in ascending order
                listEven.Sort();
                listOdd.Sort();

                // Combine the even numbers list and the odd numbers list
                listEven.AddRange(listOdd);

                // Return the sorted list as an array
                return listEven.ToArray(); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Convert the input array into a list for easier manipulation
                List<int> numsr = nums.ToList();

                // Initialize a list to store the indices of the two numbers that sum up to the target
                List<int> numsa = new List<int>();

                // Iterate through the list using the first pointer i
                for (int i = 0; i < numsr.Count; i++)
                {
                    // Use a second pointer j to check the elements after i
                    for (int j = i + 1; j < numsr.Count; j++)
                    {
                        // If the sum of the two numbers is equal to the target, store their indices
                        if (nums[i] + nums[j] == target)
                        {
                            numsa.Add(i); // Add the index of the first number
                            numsa.Add(j); // Add the index of the second number
                        }
                        else
                        {
                            continue; // If not equal, continue to check next pair
                        }
                    }
                    // If a valid pair of indices is found, break out of the loop
                    if (numsa.Count == 2)
                    {
                        break;
                    }
                    // Otherwise, continue to the next number in the list
                    else
                    {
                        continue;
                    }
                }
                // Return the indices of the two numbers that add up to the target as an array
                return numsa.ToArray(); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                // Convert the input array to a list for easier manipulation
                List<int> numst = nums.ToList();

                // Sort the list to ensure we can easily access the largest and smallest numbers
                numst.Sort();

                // Initialize the Total with the product of the first three smallest numbers
                // This is a starting point, considering the edge case with negative numbers
                int Total = numst[0] * numst[1] * numst[2];

                // Iterate through all possible combinations of three numbers
                // The first loop picks the first number i
                for (int i = 0; i < numst.Count; i++)
                {
                    int x = i + 1;// Set the second pointer to the next index after i
                    for (int j = x; j < numst.Count; j++)
                    {
                        // The second loop picks the second number j
                        int y = j + 1; // Set the third pointer to the next index after j

                        // The third loop picks the third number k
                        for (int k = y; k < numst.Count; k++)
                        {
                            // Calculate the product of the three numbers at indices i, j, k
                            int Total_1 = numst[i] * numst[j] * numst[k];

                            // If the product is larger than the current maximum product, update the Total
                            if (Total_1 > Total)
                            {
                                Total = Total_1;
                            }

                        }
                    }
                }
                // Return the maximum product found
                return Total; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                // Create a list to store the binary digits
                List<int> fin = new List<int>();

                // Loop until the decimal number becomes 0
                while (decimalNumber>0)
                {
                    // Get the remainder when divided by 2 (this gives the binary digit)
                    int x = decimalNumber % 2;

                    // Divide the number by 2 to reduce it
                    int y = decimalNumber / 2;

                    // Add the remainder (binary digit) to the list
                    fin.Add(x);

                    // Update the decimalNumber for the next iteration
                    decimalNumber = y;  
                }
                // Reverse the list to get the binary digits in the correct order
                fin.Reverse();

                // Join the list of binary digits into a string and return it
                string res = string.Join("", fin);

                // Placeholder, returns the binary representation of the number
                return res; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                // Convert the input array to a List for easier manipulation
                List<int> list21 = nums.ToList<int>();

                // Find the minimum element in the list using the Min() method
                int x = list21.Min();

                // Return the minimum element found
                return x; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                // Convert the integer x to a string
                string s = x.ToString();

                // Create a list to hold the digits of the number
                List<int> l = new List<int>();

                // Loop through each character in the string
                foreach (char c in s)
                {
                    // Convert each character to an integer and add it to the list
                    l.Add(int.Parse(c.ToString()));
                }
                // Reverse the list to compare with the original number
                l.Reverse();

                // Join the list of digits into a string
                string S1 = String.Join("", l);

                // Convert the string back to an integer
                int I = int.Parse(S1);

                // Compare the reversed number with the original number
                if (I == x)
                {
                    // If the number is the same, it's a palindrome
                    return true;
                }
                else
                {
                    // If the number is different, it's not a palindrome
                    return false;
                }
                  // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                // Check if n is 0 or 1, as these are base cases for the Fibonacci sequence
                if (n == 0) return 0;
                if (n == 1) return 1;

                // Initialize variables to store the Fibonacci numbers
                int apple = 0, ball = 1, cat = 0;

                // Loop starting from the 2nd index up to n
                for (int i = 2; i <= n; i++)
                {
                    // Calculate the next Fibonacci number by adding the last two numbers
                    cat = apple + ball;

                    // Update the previous two numbers for the next iteration
                    apple = ball; // The previous Fibonacci number becomes the second last
                    ball = cat; // The current Fibonacci number becomes the last
                }

                // Return the nth Fibonacci number after the loop completes
                return cat;
                // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
