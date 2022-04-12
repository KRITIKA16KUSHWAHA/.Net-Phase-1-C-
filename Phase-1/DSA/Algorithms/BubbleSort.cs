using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    class BubbleSort
    {
        static int[] array = { 3, 55, 44, 23, 5, 88, 12, 2 };
        public static void Do()
        {
            int n = array.Length;
            int counter = 0;
            //iteration loop
            for(int i =0; i<n-1; i++)
            {
                counter++;
                //swap loop
                for (int j=0; j < n - i - 1; j++)
                {
                    counter++;
                    if (array[j]> array[j + 1])
                    {
                        
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("iterations" + counter);
        }
    }
}
