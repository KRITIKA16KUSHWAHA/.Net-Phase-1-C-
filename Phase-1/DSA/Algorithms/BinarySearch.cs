using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    static class BinarySearch
    {
        static int[] array = { 4, 14, 44, 111, 114, 144, 244, 344, 444 };

        public static void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 344);
            Console.WriteLine("number found at index" + result);
            result = binarySearch(array, 0, array.Length - 1, 434);
            Console.WriteLine("number found at index" + result);

        }
        public static int binarySearch(int[] array, int left, int right, int num)
        {
            if (right >= left)
            {
                //1.find the mid element
                int mid = (right + left) / 2;
                //2. check if mid element is the num
                if (array[mid] == num)
                {
                    return mid;
                }
                // 3. check if numis less than mid

                if(num < array[mid])
                {
                    return binarySearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarySearch(array, mid + 1, right, num);
                }
            }
            return -1;
        }
    }
}
