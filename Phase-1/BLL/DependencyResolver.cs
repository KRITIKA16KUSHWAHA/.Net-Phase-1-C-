using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class DependencyResolver
    {
        public static object GetInstance(string type)
        {
            switch (type)
            {
                case "IFinanceTeam":
                    {
                        return new FinanceTeam();
                    }
            }
            return null;
        }
    }
}
