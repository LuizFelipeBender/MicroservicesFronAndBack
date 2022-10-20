using GeekShopping.ProductAPI.Model.Base;

namespace GeekShopping.ProductAPI.Model
{
    public class ProductAPI : BaseEntity
    {
         public class Brand
    {
        public uint Id { get; set;  }
        public string ?name { get; set; }
        public string ?picture { get; set; }
    }

    public class Gpc 
    {
        public uint Id { get; set;  }
        public string ?code { get; set; }
        public string ?description { get; set; }
    }

    public class Ncm  
    {
        public uint Id { get; set;  }
        public string ?code { get; set; }
        public string ?description { get; set; }
        public string ?full_description { get; set; }
    }

    public class ProductJson 
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
}