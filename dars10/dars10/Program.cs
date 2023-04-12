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
            Console.WriteLine("Str : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            char a = ' ';
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (arr[i] != arr[0])
                {
                    if (arr[i] != arr[i - 1])
                    {
                        a = arr[i];

                        for (int j = 0; j < str.Length; j++)
                        {
                            if (str[j] == a)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(a + " : " + count);
                        count = 0;
                    } 
                }
            }
            
            Console.ReadLine();
        }
    }
}
