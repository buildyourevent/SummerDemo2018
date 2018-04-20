using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BuildYourEvent.Models
{
    public class Event_Types
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
    }
}
