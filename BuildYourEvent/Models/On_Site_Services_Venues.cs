using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class On_Site_Services_Venues
    {
        [ForeignKey("Venues")]
        [Required]
        public short fk_Venue
        {
            get;
            set;
        }

        [ForeignKey("On_Site_Services")]
        [Required]
        public short fk_On_Site_Service
        {
            get;
            set;
        }
    }
}
