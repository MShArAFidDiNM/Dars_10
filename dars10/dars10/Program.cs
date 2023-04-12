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
            Console.Write("Array length : ");            
            int[] array = new int[int.Parse(Console.ReadLine())];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int arr = 0;
                arr = rand.Next(-10,10);
                array[i] = arr;
                sum += arr;
                Console.Write(arr+", ");
            }

            Console.WriteLine();
            Console.WriteLine("sum : "+sum);
            bool check = false;
            if (array.Length < sum)  check = true;
            Console.WriteLine(check);

            Console.ReadLine();
        }
    }
}
