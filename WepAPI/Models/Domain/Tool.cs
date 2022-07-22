using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Domain
{
    public class Tool
    {
        //Mapping dell'entità

        //[Key]
        //[MaxLength(50)]
        public string IdTool { get; set; }

        //[Required]
        //[StringLength(50)]
        public string BoschCode { get; set; }

        //[StringLength(100)]
        public string Description { get; set; }

        //[StringLength(50)]
        public string PrimarySupplier { get; set; }

        //[StringLength(50)]
        public string SecondarySupplier { get; set; }

        //[StringLength(50)]
        public string PrimarySharpener { get; set; }

        //[StringLength(50)]
        public string SecondarySharpener { get; set; }

        public int? Quantity { get; set; }

        //[StringLength(50)]
        public string PresettingQuoteNGEM1 { get; set; }

        //[StringLength(50)]
        public string PresettingQuoteNGEM2 { get; set; }

        //[StringLength(50)]
        public string PresettingDiameter { get; set; }

        //[StringLength(1)]
        public string Presetting { get; set; }

        public int? Life { get; set; }

        //[StringLength(50)]
        public string SProposal { get; set; }

        //[StringLength(50)]
        public string FProposal { get; set; }

        //[StringLength(50)]
        public string SValue { get; set; }

        //[StringLength(50)]
        public string FValue { get; set; }

        //[StringLength(50)]
        public string Refrigeration { get; set; }

        //[StringLength(100)]
        public string Accessories { get; set; }

        public ICollection<ToolMachine> ToolMachine { get; set; }

  
        public override string ToString()
        {
            // Esegui l'override di questo metodo per stampare a video le informazioni che ti interessano
            return base.ToString();
        }
    }
}
