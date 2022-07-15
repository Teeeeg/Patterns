using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Patterns.FactoryPattern
{
    public class Factory1 : IAbstractFactory
    {
        public IAbstractProduct CreateProduct1()
        {
            return new Product1();
        }

        public IAbstractProduct CreateProduct2()
        {
            return new Product2();
        }
    }
}