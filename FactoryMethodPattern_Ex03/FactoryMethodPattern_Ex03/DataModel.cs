using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Ex03
{
    public class Machine
    {
        public Machine() { }
        public Machine(int machineId, string machineCode, DateTime installDate) 
        { 
            this.MachineId = machineId;
            this.MachineCode = machineCode;
            this.InstallDate = installDate;
        }
        public int MachineId { get; set; }
       
        public string MachineCode { get; set; }
      
        public DateTime InstallDate { get; set; }
        
    }
    public class Maintenance
    {
        public Maintenance() { }
        public Maintenance(int maintenanceId, DateTime start, DateTime resolve, string comments, int machineId) 
        {
            this.MaintenanceId = maintenanceId;
            this.Start = start;
            this.Resolve = resolve;
            this.Comments = comments;
            this.MachineId = machineId;
        }
        public int MaintenanceId { get; set; }
        
        public DateTime Start { get; set; }
       
        public DateTime Resolve { get; set; }
      
        public string Comments { get; set; }

        
        public int MachineId { get; set; }
        
    }
}
