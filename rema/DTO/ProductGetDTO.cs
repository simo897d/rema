namespace rema.Controllers
{
    public class ProductGetDTO
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Units { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
    }
}