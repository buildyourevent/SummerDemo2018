using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Features_Venues
    {
        [ForeignKey("Venues")]
        [Required]
        public short fk_Venue
        {
            get;
            set;
        }

        [ForeignKey("Features")]
        [Required]
        public short fk_Feature
        {
            get;
            set;
        }
    }
}
