using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;

namespace BuildYourEvent.Models
{
    public class Locations
    {
        [Required]
        public short id
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String city
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String province
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String country
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String street
        {
            get;
            set;
        }

        [Required]
        [StringLength(7)]
        public String postal_code
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public String latitude
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public String longitude
        {
            get;
            set;
        }

    }
}
