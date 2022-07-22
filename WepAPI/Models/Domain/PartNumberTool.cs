using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Domain

{
    public class PartNumberTool
    {
        //[Key, Column(Order =0)]
        //[MaxLength(50)]
        public string PartNumber { get; set; }

        //[Key, Column(Order = 1)]
        //[MaxLength(50)]
        public string ToolCode { get; set; }


        public PartNumber ParentPartNumber { get; set; }


        public PartNumberTool(string partNumber, string toolCode)
        {
            PartNumber = partNumber;
            ToolCode = toolCode;
        }

        public PartNumberTool()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
