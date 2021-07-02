using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Cattion.Controllers;
using Cattion.Models;

namespace Cattion.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        [Display (Name = "Membership")]
        public Membership Membership { get; set; }
        public byte MembershipId { get; set; }
        public Cats Cats { get; set; }
        public byte CatsId { get; set; }

    }
}   