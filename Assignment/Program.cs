using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*
             1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given 
                an integer X, and you should print how many numbers in array that is greater than  X.
                  Ex:
                        Input
                         3 3                Size of array , number of queries
                         11 5 3             Array 
                         1                  Query1
                         5                  Query2
                         13                 Query 3
                         Output
                         3                  11,5,3
                         1                  11
                         0                   
             */
            //Console.WriteLine("Enter the Size & the number of query seperate by space"); 
            //string[] input = Console.ReadLine().Split();
            //int N = int.Parse(input[0]);
            //int Q = int.Parse(input[1]);

            //int[] array = new int[N];
            //Console.WriteLine("Enter The First Row Of Array : ");
            //input = Console.ReadLine().Split();
            //for (int i = 0; i < N; i++)
            //{
            //  array[i] = int.Parse(input[i]);
            //}


            //for (int i = 0; i < Q; i++)
            //{
            //int X = int.Parse(Console.ReadLine());
            //int count = CountGreaterThan(array, X);
            //Console.WriteLine(count);
            //}

            #endregion
            #region Q02
            /*2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
                 Ex:
                 Input:
                 5
                 1 3 2 3 1
                 Output:
                 YES */


            //Console.WriteLine("Enter Size Number : ");
            //int size = int.Parse( Console.ReadLine() );

            //int[] arr = new int[size];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse( Console.ReadLine() );
            //}

            //if (IsPalindrome(arr))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region Q03
            // 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("A");
            //queue.Enqueue("B");
            //queue.Enqueue("C");
            //ReverseQueue(queue);


            //Console.Write("Items After Reverse:");
            //Console.WriteLine();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q04
            /*
             4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
                   Ex:
                   Input:
                   [()]{}
                   Output:
                   Balanced
             */


            //string input01 = "[()]{ }{ }";  // balanced
            //string input02 = "[()]{ }}";
            //bool isBalanced = CheckBalancedParentheses(input01);

            //if (isBalanced)
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}
            #endregion
            #region Q05
            // 5. Given an array, implement a function to remove duplicate elements from an array.
            //int[] array = { 1, 2, 2, 3, 4, 4, 5, 5, 6 }; 
            //int[] result = RemoveDuplicates(array);

            //Console.WriteLine("An Array After Remove Duplicate Items: ");
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Q06
            // 6. Given an array list , implement a function to remove all odd numbers from it.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //RemoveOddNumbers(list);
            //Console.WriteLine("An Array After Removed Odd Numbers: ");
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion
            #region Q07
            /*7. Implement a queue that can hold different data types. 
                 And insert the following data:
                 queue.Enqueue(1)
                 queue.Enqueue(“Apple”)
                 queue.Enqueue(5.28)*/

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //Console.WriteLine("Queue Have :");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q08
            /*
             8. Create a function that pushes a series of integers onto a stack. 
                Then, search for a target integer in the stack. If the target is found, 
                print a message indicating that the target was found how many elements 
                were checked before finding the target (“Target was found successfully and the count = 5”). 
                If the target is not found, print a message indicating that the target was not found(“Target was not found”).
                Note : take the target as input from the user.
             */


            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);


            //Console.WriteLine("==========================");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine("Enter The Target Input : ");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("==========================");
            //GetTarget(stack, input);

            #endregion
            #region Q09
            /* 9. Given two arrays, find their intersection.
                  Each element in the result should appear as many times as it shows in both arrays*/


            //Console.WriteLine("Enter Size Of Array01 : ");
            //int Siza01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Size Of Array02 : ");
            //int Siza02 = int.Parse(Console.ReadLine());

            //List<int> list01 = new List<int>(Siza01);
            //List<int> list02 = new List<int>(Siza02);

            //Console.WriteLine("Enter Values Of Array01 (sepaareted by space )");
            //string input01 = Console.ReadLine();
            //string[] val01 = input01.Split(" ");

            //foreach (var value in val01)
            //{
            //    list01.Add(int.Parse(value));
            //}
            //Console.WriteLine("Enter Values Of Array02 (sepaareted by space )");
            //string input02 = Console.ReadLine();
            //string[] val02 = input02.Split(" ");
            //foreach (var value in val02)
            //{
            //    list02.Add(int.Parse(value));
            //}
            //Console.WriteLine("\nContents of Array01:");
            //foreach (var item in list01)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine("\nContents of Array02:");
            //foreach (var item in list02)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("::::::::::::::::::::::::::::::");
            //Console.WriteLine();
            //FindInterSection(list01,list02);
            #endregion
            #region Q10
            /*10. Given an ArrayList of integers and a target sum, find if there is a 
                  contiguous sub list that sums up to the target.*/
            
            
            //Console.WriteLine("Enter the target sum:");
            //int target = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements of the ArrayList separated by space:");
            //string input = Console.ReadLine();
            //string[] values = input.Split(" ");

            //List<int> numbers = new List<int>();
            //foreach (string value in values)
            //{
            //    numbers.Add(int.Parse(value));
            //}

            //List<int> result = FindContiguousSublistThatSumsToTarget(numbers, target);

            //if (result.Count > 0)
            //{
            //    Console.WriteLine("Found sublist:");
            //    Console.WriteLine(string.Join(" ", result));
            //}
            //else
            //{
            //    Console.WriteLine("No sublist found.");
            //}
            #endregion
        }
        static int CountGreaterThan(int[] array, int X)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number > X)
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsPalindrome(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                if (arr[start] != arr[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
        static void ReverseQueue(Queue<string> queue)
        {
            Stack<string> stack = new Stack<string>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static bool CheckBalancedParentheses(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), ch))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
        static int[] RemoveDuplicates(int[] array)
        {
            if (array.Length == 0) return array;
            Array.Sort(array);


            int[] tempArray = new int[array.Length];
            int index = 0;


            tempArray[index++] = array[0];


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    tempArray[index++] = array[i];
                }
            }
            int[] resultArray = new int[index];
            Array.Copy(tempArray, resultArray, index);
            return resultArray;
        }
        static void RemoveOddNumbers(List<int> arr)
        {
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    arr.RemoveAt(i);// Remove at to remove specific item in specific index
                }
            }
        }
        static void GetTarget(Stack<int> stack, int target)
        {
            if (stack != null & stack.Count > 0)
            {
                int count = 0;
                bool found = false;
                foreach (var item in stack)
                {
                    count++;
                    if (item.Equals(target))
                    {
                        found = true;
                        Console.WriteLine($"Target was found successfully and the count = {count}");
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Target was not found");
                }
            }
            else
            {
                Console.WriteLine("The Stack Is Empty Or Null ");
            }
        }
        static void FindInterSection(List<int> list01, List<int> list02)
        {
            if (list01 != null & list02 != null & list01.Count > 0 & list02.Count > 0)
            {
                for (int i = 0; i < list01.Count; i++)
                {
                    for (int j = 0; j < list02.Count; j++)
                    {
                        if (list01[i].Equals(list02[j]))
                        {
                            Console.WriteLine(list01[i]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("One or both lists are empty or null.");
            }
        }
        static List<int> FindContiguousSublistThatSumsToTarget(List<int> numbers, int target)
        {
            for (int i = 0; i < numbers.Count; i++) // start
            {
                int sum = 0;
                List<int> SubList = new List<int>();
                for (int j = 0; j < numbers.Count; j++) // end
                {
                    sum += numbers[j];
                    SubList.Add(numbers[j]);
                    if (sum.Equals(target))
                    {
                        return SubList;
                    }
                    else if (sum > target)
                    {
                        break;
                    }

                }
            }
            return new List<int>();
        }

    }
}
