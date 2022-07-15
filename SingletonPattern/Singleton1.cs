using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Singleton1
    {
        private static Singleton1 instance = null;
        private Singleton1()
        {

        }

        public static Singleton1 GetSingleton1()
        {
            if (instance is null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }
}