using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FastFood.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
