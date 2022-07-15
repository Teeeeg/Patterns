using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void Reset()
        {
            this.product = new Product();
        }
        public void BuildPartA()
        {
            this.product.Add("PartA");
        }

        public void BuildPartB()
        {
            this.product.Add("PartB");
        }

        public void BuildPartC()
        {
            this.product.Add("PartC");
        }

        public Product GetProduct()
        {
            Product res = this.product;
            this.Reset();
            return res;
        }
    }
}