using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Singleton4
    {
        private Singleton4()
        {

        }
        private static Lazy<Singleton4> instance = new Lazy<Singleton4>(() => new Singleton4(), true);

        public static Singleton4 GetSingleton4() => instance.Value;
    }
}