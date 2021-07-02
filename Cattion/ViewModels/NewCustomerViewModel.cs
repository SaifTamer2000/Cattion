using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cattion.Models;

namespace Cattion.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Membership> memberships { get; set; }
        public Customer Customer { get; set; }
    }
}