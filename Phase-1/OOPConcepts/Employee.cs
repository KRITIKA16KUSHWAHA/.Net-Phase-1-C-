using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    abstract class Employee
    {
        public IITTeam ITTeam { get; set; }
        public IFinanceTeam FinanceTeam { get; set; }

        public Employee(int id, string name, string dept ,IFinanceTeam fteam /*, IITTeam itteam*/)
        {
            this.ID = id;
            this.Name = name;
            this.Department = dept;
           // ITTeam = itteam;
            FinanceTeam = fteam;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void DoWork()
        {
            //Do Work

            ITTeam.SolveProblem();
        }

        public void GetSalary()
        {
            //get salary

            Console.WriteLine(this.ID);
            Console.WriteLine("Salary Credited");
            FinanceTeam.TakeRequestFromEmployee();

        }


    }
}
