using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class ReverseString
    {
        public void Do()
        {
            Console.WriteLine("Please Enter String");
            string input= Console.ReadLine();

            string result = string.Empty;
            for(int i=input.Length-1; i>=0; i--)
            {
                result = result + input[i];
            }
            Console.WriteLine(result);

        }
    }
}
