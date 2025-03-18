using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class DellFactory : IComputerFactory
    {
        public IBrand brand()
        {
            return new Dell();
        }

        public virtual IComputerType computerType()
        {
            return new Desktop();
        }

        public IProcessorType processorType()
        {
            return new ProcessorI7();
        }
    }

    public class DellFactoryLaptop : DellFactory
    {
        public override IComputerType computerType()
        {
            return new Laptop();
        }
    }
}