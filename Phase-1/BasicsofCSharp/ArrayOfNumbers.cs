using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class ArrayOfNumbers
    {
        int[] array = { 20, 30, 40, 50, 60, 70 };

        public void Do()
        {
            foreach(int num in array)
            {
                Console.Write(num);
                Console.Write(" \n ");

            }
        }
    }
}
