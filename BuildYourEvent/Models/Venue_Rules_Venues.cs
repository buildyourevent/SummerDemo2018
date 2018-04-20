using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Venue_Rules_Venues
    {
        [ForeignKey("Venues")]
        [Required]
        public short fk_Venue
        {
            get;
            set;
        }

        [ForeignKey("Venue_Rules")]
        [Required]
        public short fk_Venue_Rule
        {
            get;
            set;
        }
    }
}
