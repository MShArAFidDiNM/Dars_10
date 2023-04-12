using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dars10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[][] arr = new int[5][];          
            int diaganalsum = 0; 
            int diaganalsum2 = 0; 
            int arraylengthsum = 0; 
            int sum = 0;
         

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[5];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(1, 10);
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < arr.Length; i++)
            {
                for(int j = 0;j < arr.Length; j++)
                {
                    if (i + j == arr.Length - 1 ) diaganalsum += arr[i][j];
                    if (i == 0 ) sum += arr[i][j];
                    if (i == j ) diaganalsum2+= arr[i][j];
                    if (i == arr.Length - 1 ) arraylengthsum += arr[i][j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("Diaganalsum : " + diaganalsum);
            bool check = false;
            if (diaganalsum > sum) check = true;
            Console.WriteLine(check); 
            Console.WriteLine();
            Console.WriteLine("Array Length Sum : " + arraylengthsum);
            Console.WriteLine("Diaganalsum : " + diaganalsum2);
            bool check1 = false;
            if (diaganalsum2 > arraylengthsum) check = true;
            Console.WriteLine(check);

            Console.ReadLine();
        }
    }
}
