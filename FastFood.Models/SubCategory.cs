using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FastFood.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
