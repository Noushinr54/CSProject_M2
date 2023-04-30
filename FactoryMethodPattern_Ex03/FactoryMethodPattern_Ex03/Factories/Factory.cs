using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Ex03.Factories
{
    public class Factory : IFactory
    {
        public T Create<T>(params object[] args) where T : class
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }
    }
}
