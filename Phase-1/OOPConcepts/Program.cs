using BLL;
using System;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee(1, "john doe", "HR",50000, (IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"));
            emp1.GetSalary();
            emp1.GetBenifits("Insurance");
        }
    }
}
