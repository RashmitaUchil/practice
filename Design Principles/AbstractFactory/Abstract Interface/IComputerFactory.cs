using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public interface IComputerFactory
    {
        IBrand brand();

        IComputerType computerType();

        IProcessorType processorType();
    }
}