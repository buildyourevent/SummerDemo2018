using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Photos
    {
        [Required]
        public short id
        {
            get;
            set;
        }

        [Required]
        [StringLength(2048)]
        public String filename
        {
            get;
            set;
        }

        [Required]
        [StringLength(2048)]
        public String url
        {
            get;
            set;
        }
        [ForeignKey("Venues")]
        [Required]
        public short fk_Venue
        {
            get;
            set;
        }
    }
}
