using GeekShopping.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;
using static GeekShopping.ProductAPI.Model.ProductAPI;

namespace GeekShopping.ProductAPI.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(){}
        public MysqlContext(DbContextOptions<MysqlContext> options): base(options) {}

        //public DbSet<Product> ?Products { get; set; }
        public DbSet<Product> Products => Set<Product>();

        public DbSet<Ncm> Ncms => Set<Ncm>();

        public DbSet<Gpc> Gpcs => Set<Gpc>();

        public DbSet<Brand> Brands => Set<Brand>();

        public DbSet<ProductJson> ProductJsons => Set<ProductJson>();
    
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Apple",
                Price = new decimal(12.29),
                Description = "Apple fruit",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                Product_Category_Name = "Fruit"
            });

             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Grape",
                Price = new decimal(3.29),
                Description = "Grape fruit",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                Product_Category_Name = "Fruit"
            });

             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Grape",
                Price = new decimal(3.29),
                Description = "Grape fruit",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Alice_%28apple%29.jpg/180px-Alice_%28apple%29.jpg",
                Product_Category_Name = "Fruit"
            });
 
 
            // modelBuilder.Entity<ProductTest.ProductAPI>().HasData(new ProductTest.ProductAPI
            // {
            //     Id = 1,


                
            // });

        }
    }
}