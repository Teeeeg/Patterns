using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string res = string.Empty;
            foreach (var item in _parts)
            {
                res += item + ", ";
            }

            return res;
        }
    }
}