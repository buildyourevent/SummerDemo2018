using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Order_States
    {
        [Required]
        public short id
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        public String name
        {
            get;
            set;
        }
    }
}
