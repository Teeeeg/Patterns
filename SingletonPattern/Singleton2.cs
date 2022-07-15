using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Singleton2
    {
        private static Singleton2 instance = null;
        private Singleton2()
        {

        }

        public static Singleton2 GetSingleton2()
        {
            lock (typeof(Singleton2))
            {
                if (instance is null)
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }
    }
}