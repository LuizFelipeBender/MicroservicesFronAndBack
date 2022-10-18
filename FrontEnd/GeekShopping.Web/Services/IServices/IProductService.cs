using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();

        Task<ProductModel> FindProductById(uint id);

        Task<ProductModel> CreateProduct(ProductModel model);

        Task<ProductModel> UpadateProduct(ProductModel model);

        Task<bool> DeleteProductById(uint id);
    }
}