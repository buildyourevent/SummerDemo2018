using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildYourEvent.Models
{
    public class Users
    {
        [Required]
        public short id
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        public String first_name
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        public String last_name
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        public String user_name
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String password
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public String email
        {
            get;
            set;
        }
    }
}