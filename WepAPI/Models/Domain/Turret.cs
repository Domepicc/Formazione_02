using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebAPI.Domain
{
    public class Turret
    {
        //[Key]
        //[MaxLength(50)]
        public string TurretCode { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Description { get; set; }

        public Turret()
        {

        }

        public Turret(string turretCode, string description)
        {
            TurretCode = turretCode;
            Description = description;
        }

        public override string ToString()
        {
            // Esegui l'override di questo metodo per stampare a video le informazioni che ti interessano
            return base.ToString();
        }

    }
}
