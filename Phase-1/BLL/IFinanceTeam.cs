using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IFinanceTeam
    {
        void SendSalary();
        void CalculateSalary();
        void TakeRequestFromEmployee();

    }
}
