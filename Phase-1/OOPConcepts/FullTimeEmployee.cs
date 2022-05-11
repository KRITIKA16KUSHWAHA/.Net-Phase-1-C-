using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    class FullTimeEmployee: Employee, IEmployeeBenifits
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int id, string name, string dept, int monthlySal, IFinanceTeam fteam): base(id, name, dept, fteam)
        {
            this.MonthlySalary = monthlySal;
        }

        public void GetBenifits()
        {
            // Logic
        }

        // method overloading/ compile time method overloading (name matches but either number or type of parameter must be deifferent
        public int GetBenifits(string BenifitName)
        {
            // Logic
            return 1;
        }

        //run time polymorphism or method overriding
        public override void GetSalary()
        {
            Console.WriteLine("Salary credited to FullTimeEmployee Class");
        }
    }
}
