using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain
{
    public class Machine : IComparable<Machine>
    {

        public string MachineCode { get; set; }

        public string Description { get; set; }

        public string StoreToolsFileName { get; set; }

        public string Line { get; set; }

        public ICollection<ToolMachine> ToolMachine { get; set; }

        public Machine()
        {
            ToolMachine = new List<ToolMachine>();
        }

        public int CompareTo(Machine other)
        {
            return this.MachineCode.CompareTo(other.MachineCode);
        }
    }

}
