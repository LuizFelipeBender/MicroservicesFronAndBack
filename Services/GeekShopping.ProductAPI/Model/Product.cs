using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.ProductAPI.Model.Base;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("Product_Name")]
        [Required(ErrorMessage = "Product Name must be provided.")]
        [StringLength(100,MinimumLength=2, ErrorMessage = "The product name must be at least 2 characters and a maximum of 100.")]
        public string ?Name { get; set; }

        [Column("Product_Price")]
        [Required(ErrorMessage = "Product Price must be provided.")]
        [Range(0,100000)]
        public decimal Price { get; set; }

        [Column("Product_Description")]
        [Required(ErrorMessage = "Product Description must be provided.")]  
        [StringLength(255,MinimumLength=4, ErrorMessage = "The product description must be at least 2 characters and a maximum of 100.")]
        public string ?Description { get; set; }

        [Column("Product_Category_Name")]
        [Required(ErrorMessage="Product_Category_Name  must be provided.")]
        [StringLength(50,MinimumLength = 3, ErrorMessage=@" The name must be at least {1} characters and a maximum of {1}." )]
        public string ?Product_Category_Name { get; set; }

        [Column("Image_url")]
        [StringLength(255)]
        public string ?ImageURL { get; set; }

        }
}