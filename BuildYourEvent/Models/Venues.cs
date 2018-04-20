using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BuildYourEvent.Models
{
    public class Venues
    {
        [Required]
        public short id
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String name
        {
            get;
            set;
        }

        [Required]
        public short guest_capacity
        {
            get;
            set;
        }

        [Required]
        public double venue_size_sqf
        {
            get;
            set;
        }

        [Required]
        public Decimal price_hourly
        {
            get;
            set;
        }

        [Required]
        //[DataType(DataType.Currency)]
        public Decimal price_daily
        {
            get;
            set;
        }

        [ForeignKey("Locations")]
        [Required]
        public short fk_location
        {
            get;
            set;
        }
        [ForeignKey("Vendors")]
        [Required]
        public short fk_Vendor
        {
            get;
            set;
        }

    }
}
