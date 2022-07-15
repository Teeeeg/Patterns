using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Singleton3
    {
        private static Singleton3 instance = null;
        private Singleton3()
        {

        }

        public static Singleton3 GetSingleton3()
        {
            if (instance is null)
            {
                lock (typeof(Singleton3))
                {
                    if (instance is null)
                    {
                        instance = new Singleton3();
                    }
                }

            }
            return instance;
        }
    }
}