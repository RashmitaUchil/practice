using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory? getComputer(Employee e)
        {
            if (e.type == Employee.EmployeeType.Permanent)
            {
                if (e.position == Employee.Position.Manager)
                {
                    return new AppleFactoryLaptop();
                }
                else
                {
                    return new AppleFactory();
                }
            }
            else if (e.type == Employee.EmployeeType.Contract)
            {
                if (e.position == Employee.Position.Manager)
                {
                    return new DellFactoryLaptop();
                }
                else { return new DellFactory(); }
            }
            return null;
        }
    }
}