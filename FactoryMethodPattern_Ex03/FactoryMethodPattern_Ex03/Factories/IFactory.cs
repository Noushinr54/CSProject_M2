using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Ex03.Factories
{
    public interface IFactory
    {
        T Create<T>(params object[] args) where T : class;
    }
}
