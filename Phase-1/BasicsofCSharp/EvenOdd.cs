using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class EvenOdd
    {
        public void Do()
        {
            Console.WriteLine("Enter the number to check even or odd or enter zero to exit");
                      
            bool keeprunning = true;

            while (keeprunning)
            {
                string input = Console.ReadLine();
                int value = Convert.ToInt32(input);
                if (value == 0)
                {
                    keeprunning = false;
                    break;
                }

                if (value % 2 == 0)
                {
                    Console.WriteLine("this is even number");
                }
                else
                {
                    Console.WriteLine("This is odd number");
                }
            }
        }
    }
}
