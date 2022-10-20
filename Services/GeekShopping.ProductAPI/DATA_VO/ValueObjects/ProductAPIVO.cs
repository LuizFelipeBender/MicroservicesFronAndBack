using static GeekShopping.ProductAPI.Model.ProductAPI;

namespace GeekShopping.ProductAPI.DATA_VO.ValueObjects
{
    public class ProductAPIVO
    {
        public uint Id { get; set;  }
        public double avg_price { get; set; }
        public Brand ?brand { get; set; }
        public string ?description { get; set; }
        public Gpc ?gpc { get; set; }
        public int gross_weight { get; set; }
        public long gtin { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public double max_price { get; set; }
        public Ncm ?ncm { get; set; }
        public int net_weight { get; set; }
        public string ?price { get; set; }
        public string ?thumbnail { get; set; }
        public double width { get; set; }
    }
}