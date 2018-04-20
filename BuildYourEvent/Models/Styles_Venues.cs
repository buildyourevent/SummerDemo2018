using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Styles_Venues
    {
        [ForeignKey("Venues")]
        [Required]
        public short fk_Venue
        {
            get;
            set;
        }

        [ForeignKey("Styles")]
        [Required]
        public short fk_Style
        {
            get;
            set;
        }
    }
}
