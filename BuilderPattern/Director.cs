using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { this._builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFeatureProdcut()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}