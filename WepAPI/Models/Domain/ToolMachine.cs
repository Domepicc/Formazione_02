using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Domain
{
    public class ToolMachine
    {
        [Key, Column(Order = 1)]
        public string IdTool { get; set; }

        [Key, Column(Order = 2)]
        public string MachineCode { get; set; }

        public Tool Tool { get; set; }

        public Machine Machine { get; set; }


        public ToolMachine(string id, string id2)
        {
            IdTool = id;
            MachineCode = id2;
        }

        public ToolMachine()
        {

        }
    }


}
