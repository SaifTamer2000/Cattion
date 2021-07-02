using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cattion.Models;

namespace Cattion.ViewModels
{
    public class CuteCatViewModel
    {
        public Cats Cats { get; set; }
        public List<Customer> Customers { get; set; }
    }
}