﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IBrand
    {
        string GetBrand();
    }

    public interface IComputerType
    {
        string GetComputer();
    }

    public interface IProcessorType
    {
        string GetProcessor();
    }
}