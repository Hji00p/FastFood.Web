using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FastFood.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public String PostalCode { get; set; }

    }
}
