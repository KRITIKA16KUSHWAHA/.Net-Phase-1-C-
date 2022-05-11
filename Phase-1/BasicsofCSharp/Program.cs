using System;

namespace BasicsofCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // DataTypes dt = new DataTypes();
            // dt.Do();

            //EvenOdd even = new EvenOdd();
            //even.Do();

            // ReverseString reverse = new ReverseString();
            // reverse.Do();


            // new ArrayOfNumbers().Do();

            // new FileOperations().WriteFile();
            //new FileOperations().UpdateFile();
            //new FileOperations().ReadFile();

            //new FileOperations().DeleteFile();
            /*    new MiniProject().Project();
                new MiniProject().AddData();
                new MiniProject().ReadAll();

                new MiniProject().UpdateData();
                new MiniProject().Delete();*/

            new PhaseOneProject().CreateFile();
            new PhaseOneProject().AddTeacherData();
            new PhaseOneProject().ReadAllTeacherData();



        }
    }
}
