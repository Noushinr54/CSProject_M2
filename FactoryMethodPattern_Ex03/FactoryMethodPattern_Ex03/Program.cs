using FactoryMethodPattern_Ex03.Factories;
using FactoryMethodPattern_Ex03.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory f = new Factory();
            TestClass t = new TestClass(f);
            t.TestMethod();
            Console.ReadLine();
        }
    }
}
