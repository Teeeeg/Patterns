using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
    public class Product2 : IAbstractProduct
    {
        public Product2()
        {
            System.Console.WriteLine("Product2 Created ");
        }
        public int Size { get; set; }
        public int Ice { get; set; }
    }
}