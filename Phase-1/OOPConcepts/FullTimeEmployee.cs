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
            throw new NotImplementedException();
        }
    }
}
