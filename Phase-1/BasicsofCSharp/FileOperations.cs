using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class FileOperations
    {
        public void WriteFile()
        {
            String content = "Name, ID, Dept";
            File.WriteAllText("C://Dell.netFSD//employee.txt", content);
        }

        public void UpdateFile()
        {
            String Empdetail = "\nJohn, 1, HR";
            File.AppendAllText("C://Dell.netFSD//employee.txt", Empdetail);
        }
        public void ReadFile()
        {
            string content = File.ReadAllText("C://Dell.netFSD//employee.txt");
            Console.WriteLine(content);

            string[] contents = File.ReadAllLines ("C://Dell.netFSD//employee.txt");
            foreach (string str in contents)
            { 
                Console.WriteLine(str);
            }
        }

        public void DeleteFile()
        {
            if (File.Exists("C://Dell.netFSD//employee.txt"))
            {
                File.Delete("C://Dell.netFSD//employee.txt");
            }
        }
        
            
     
        
    }
}
