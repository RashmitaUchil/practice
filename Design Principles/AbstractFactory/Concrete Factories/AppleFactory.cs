using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class AppleFactory : IComputerFactory
    {
        public IBrand brand()
        {
            return new Apple();
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

    public class AppleFactoryLaptop : AppleFactory
    {
        public override IComputerType computerType()
        {
            return new Laptop();
        }
    }
}