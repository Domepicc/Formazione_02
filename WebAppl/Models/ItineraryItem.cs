using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAppl.Models
{
    [MetadataType (typeof (ItineraryItemAttributes))]
    public class ItineraryItem
    {
        
        public DateTime? When { get; set; }
        public string Description { get; set; }
        public int? Duration { get; set; }
        public bool IsActive { get; set; }
        public bool? Confirmed { get; set; }

    }
}