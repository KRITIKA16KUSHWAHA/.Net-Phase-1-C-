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

        private int _ID;
        public int ID
        { 
            get 
            {
                //If user is valid
                 return this._ID;
               
            }

            set
            {
                if (!this.Validate(value))
                {
                    throw new Exception("invalid value");
                }
                this._ID = ID;
                
            }
        }
        private bool Validate(int id)
        {
            //Db Calls
            if (id < 1)
            {
                return false;
            }
            return true;
        }
        public string Name { get; set; }
        public string Department { get; set; }

        public void DoWork()
        {
            //Do Work

            ITTeam.SolveProblem();
        }

        public virtual void GetSalary()
        {
            //get salary

            Console.WriteLine(this.ID);
            Console.WriteLine("Salary Credited in base");
            FinanceTeam.TakeRequestFromEmployee();

        }


    }
}
