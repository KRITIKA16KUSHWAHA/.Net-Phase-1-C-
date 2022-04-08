using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class MiniProject
    {
        public void Project()
        {
            //Console.WriteLine("Please enter student ID, nameof and dept");
            string details = "id, Name, Dept";
            File.WriteAllText("C://Dell.netFSD//students.txt", details);

            
        }
        public void AddData()
        {
            Console.WriteLine("Add/update students in list or enter 0 to exit");
            bool addmore = true;
             while (addmore)
            {
                string sdetail = Console.ReadLine();
                
                if (sdetail == "0")
                {
                    Console.WriteLine("Thankyou for closing the file");
                    addmore = false;
                    break;
                }
                File.AppendAllText("C://Dell.netFSD//students.txt", "\n");
                File.AppendAllText("C://Dell.netFSD//students.txt", sdetail);

                          
            }
                        
        }
        public void ReadAll()
        {
            Console.WriteLine("Showing all the data");
            string Student = File.ReadAllText("C://Dell.netFSD//students.txt");
            Console.WriteLine(Student);


            Console.WriteLine("display only id");
            string[] students = File.ReadAllLines("C://Dell.netFSD//students.txt");
            foreach (string studid in students)
            {
                //Console.WriteLine(studid);
                string id = studid.Split(",")[0];
                Console.WriteLine(id);
            }

        }
                   
        public void UpdateData()
        {
            Console.WriteLine("Enter the record to Update");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C://Dell.netFSD//students.txt");
            string resultContent = string.Empty;
            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                if (str1[0] == input1[0])
                {
                    resultContent += input;
                    resultContent += "\n";
                }
                else
                {
                    resultContent += str;
                    resultContent += "\n";
                }
            }
            File.WriteAllText("C://Dell.netFSD//students.txt", resultContent);
            Console.WriteLine("Record Updated!");

        }

        public void Delete()
        {
            Console.WriteLine("Enter the record to Delete from the list");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C://Dell.netFSD//students.txt");
            string resultContent = string.Empty;
            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                if (str1[0] == input1[0])
                {
                    resultContent += string.Empty;
                    //resultContent += "\n";
                }
                else
                {
                    resultContent += str;
                    resultContent += "\n";
                }
            }
            File.WriteAllText("C://Dell.netFSD//students.txt", resultContent);
            Console.WriteLine("Record Deleted!");
        }


    }

       
}
