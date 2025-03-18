using static AbstractFactory.Enumerations;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class ProcessorI3 : IProcessorType
    {
        public string GetProcessor()
        {
            return ProcessorName.I3.ToString();
        }
    }

    public class ProcessorI5 : IProcessorType
    {
        public string GetProcessor()
        {
            return ProcessorName.I5.ToString();
        }
    }
        public class ProcessorI7 : IProcessorType
        {
            public string GetProcessor()
            {
                return ProcessorName.I7.ToString();
            }
        }
    
}