using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PermanentEmployee : IEmployeeManager
    {
        public int bonus()
        {
            return 10;
        }

        public int hourlyPay()
        {
            return 8;
        }
    }
}