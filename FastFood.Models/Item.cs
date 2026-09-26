using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }
        public int CaategoryId { get; set; }
        public Category Category { get; set; }
        public int SubCategoryId {  get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
