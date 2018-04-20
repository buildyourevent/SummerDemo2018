using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Bookings
    {
        [Required]
        public short id
        {
            get;
            set;
        }

        [ForeignKey("Users")]
        [Required]
        public short fk_User
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

        [ForeignKey("Order_States")]
        [Required]
        public short fk_Order_State
        {
            get;
            set;
        }

    }
}
