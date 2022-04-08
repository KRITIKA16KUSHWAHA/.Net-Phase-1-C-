using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    class LinearSearch
    {
        static int[] array = { 12, 15, 17, 19, 20, 23, 26 };
        //T(n)=O(n)
        public static void Do()
        {
            Console.WriteLine("Please enter a number to search in array");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i< array.Length;i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("number found at index" + i);
                    return;
                }
            }
            Console.WriteLine("Number does not exist in array");

        }
    }
}
