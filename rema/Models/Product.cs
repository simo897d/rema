using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rema.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Units { get; set; }
        public int Quantity { get; set; }
        public Category category { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public Supplier Supplier { get; set; }
    }
}
