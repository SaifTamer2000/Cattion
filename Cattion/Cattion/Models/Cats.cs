using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cattion.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Cattion.Models
{
    public class Cats
    {
        public int id { get; set; }
        public string name { get; set; }
        
        public string imagepath { get; set;  }

        public Cats()
        {
            imagepath = "/Content/Images/catto.jpg";
        }

    }
}