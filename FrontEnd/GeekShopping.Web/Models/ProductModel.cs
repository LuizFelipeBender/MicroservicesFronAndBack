namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Product_Category_Name { get; set; }
        public string ImageURL { get; set; }
    }
}