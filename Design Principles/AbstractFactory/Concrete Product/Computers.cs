using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using static AbstractFactory.Enumerations;

namespace AbstractFactory
{
    public class Laptop : IComputerType
    {
        public string GetComputer()
        {
            return ComputerType.Laptop.ToString();
        }
    }
    public class Desktop : IComputerType
    {
        public string GetComputer()
        {
            return ComputerType.Desktop.ToString();
        }
    }
}