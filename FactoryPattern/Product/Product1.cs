using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
    public class Product1 : IAbstractProduct
    {
        public Product1()
        {
            System.Console.WriteLine("Product1 Created ");
        }

        public int Size { get; set; }
        public int Ice { get; set; }


    }
}