using System.Collections.Generic;

namespace rema.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public List<Product> Products { get; set; }
    }
}