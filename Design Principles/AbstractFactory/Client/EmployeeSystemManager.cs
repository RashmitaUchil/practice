using AbstractFactory.Interfaces;

namespace AbstractFactory.Client
{
    public class EmployeeSystemManager
    {
        private IComputerFactory? computerFactory;

        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }

        public string GetDetails()
        {
            IBrand brand = computerFactory.brand();
            IProcessorType processor = computerFactory.processorType();
            IComputerType computer = computerFactory.computerType();

            string result = "Brand:" + brand.GetBrand() + " Processor:" + processor.GetProcessor() + " System:" + computer.GetComputer();
            return result;
        }
    }
}