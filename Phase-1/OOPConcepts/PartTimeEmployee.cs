using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    class PartTimeEmployee: Employee, IEmployeeBenifits
    {
        public int HourlySalary { get; set; }
        public PartTimeEmployee(int id, string name, string dept, int hourlySal, IFinanceTeam fteam) : base(id, name, dept, fteam)
        {
            this.HourlySalary = hourlySal;
        }

        public void GetBenifits()
        {
            throw new NotImplementedException();
        }
    }
}
