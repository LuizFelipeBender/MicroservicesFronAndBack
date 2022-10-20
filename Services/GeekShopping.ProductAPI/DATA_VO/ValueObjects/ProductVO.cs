namespace GeekShopping.ProductAPI.DATA_VO.ValueObjects
{
    public class ProductVO
    {
        public uint Id { get; set; }
        public string ?Name { get; set; }
        public decimal Price { get; set; }
        public string ?Description { get; set; }
        public string ?Product_Category_Name { get; set; }
        public string ?ImageURL { get; set; }
    }

    // public class ProductVOID
    // {
    //     public uint Id { get; set; }
    //     public string ?Name { get; set; }
    //     public decimal Price { get; set; }
    //     public string ?Description { get; set; }
    //     public string ?Product_Category_Name { get; set; }
    //     public string ?ImageURL { get; set; }
    // }
}