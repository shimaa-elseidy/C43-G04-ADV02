namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
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
    }
}
