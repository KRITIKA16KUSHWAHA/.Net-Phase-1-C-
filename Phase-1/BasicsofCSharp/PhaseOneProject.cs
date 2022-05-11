using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCSharp
{
    class PhaseOneProject
    {
        public void CreateFile()
        {
            String content = "Name, ID, Class,Section";
            File.WriteAllText("C://Dell.netFSD//Teacher.txt", content);
        }

        public void AddTeacherData()
        {
            Console.WriteLine("Add Teacher Data in list or enter 0 to exit");
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
                File.AppendAllText("C://Dell.netFSD//Teacher.txt", "\n");
                File.AppendAllText("C://Dell.netFSD//Teacher.txt", sdetail);


            }

        }

        public void ReadAllTeacherData()
        {
            Console.WriteLine("Showing all the data");
            string Teacher = File.ReadAllText("C://Dell.netFSD//Teacher.txt");
            Console.WriteLine(Teacher);


            Console.WriteLine("display only id");
            string[] teachers = File.ReadAllLines("C://Dell.netFSD//Teacher.txt");
            foreach (string tchrid in teachers)
            {
                //Console.WriteLine(studid);
                string id = tchrid.Split(",")[0];
                Console.WriteLine(id);
            }

        }


        public void UpdateTeacherData()
        {
            Console.WriteLine("Enter the record to Update");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C://Dell.netFSD//Teacher.txt");
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
            File.WriteAllText("C://Dell.netFSD//Teacher.txt", resultContent);
            Console.WriteLine("Record Updated!");

        }

        public void Delete()
        {
            Console.WriteLine("Enter the record to Delete from the list");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C://Dell.netFSD//Teacher.txt");
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
            File.WriteAllText("C://Dell.netFSD//Teacher.txt", resultContent);
            Console.WriteLine("Record Deleted!");
        }



    }
}
