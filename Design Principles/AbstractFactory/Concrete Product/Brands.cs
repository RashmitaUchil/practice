using AbstractFactory.Interfaces;
using static AbstractFactory.Enumerations;

namespace AbstractFactory
{
    public class Apple : IBrand
    {
        public string GetBrand()
        {
            return BrandName.APPLE.ToString();
        }
    }

    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return BrandName.DELL.ToString();
        }
    }
}