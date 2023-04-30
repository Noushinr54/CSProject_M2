using FactoryMethodPattern_Ex03.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Ex03.Tests
{
    public class TestClass
    {
        IFactory f;
        public TestClass(IFactory f) 
        { 
            this.f = f;
        }
        public void TestMethod()
        {
            var machines = new[]
            {
                this.f.Create<Machine>(1, "D-10", new DateTime(2020, 2, 17)),
                this.f.Create<Machine>(2, "C-10T", new DateTime(2020, 1, 7)),
                this.f.Create<Machine>(3, "L-10Y", new DateTime(2020, 12, 1))

            };
            Console.WriteLine("Machines");
            machines.ToList()
                .ForEach(m => Console.WriteLine($"Id: {m.MachineId} Code: {m.MachineCode} Install date: {m.InstallDate:yyyy-MM-dd}"));
            var maintenances = new[]
            {
                this.f.Create<Maintenance>(1, new DateTime(2022, 3, 3), new DateTime(2022, 3, 9), "Hydraulic replacement", 1),
                this.f.Create<Maintenance>(1, new DateTime(2022, 2, 1), new DateTime(2022, 2, 14), "Rollchain repair", 2),
                this.f.Create<Maintenance>(1, new DateTime(2022, 3, 3), new DateTime(2022, 3, 9), "Wheel replacement", 3)
            };
            Console.WriteLine("Maintenance");
            maintenances.ToList()
                .ForEach(m => Console.WriteLine($"Id: {m.MaintenanceId} Started: {m.Start:yyyy-MM-dd} Resolved: {m.Resolve:yyyy-MM-dd} Machine Id:{m.MachineId}, Comments: {m.Comments}"));
        }
    }
}
