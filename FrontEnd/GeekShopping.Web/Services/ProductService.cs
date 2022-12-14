using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public const string BasePath = "api/v1/product";
        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Could not create product");
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(uint id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
            // var response = await _client.GetAsync(BasePath);
            // return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> UpadateProduct(ProductModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Could not create product");
        }

        public async Task<bool> DeleteProductById(uint id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode){
                bool success = true;
                return  success; //ERRO SE DA NESSA LINHA
            }
            else throw new Exception("Something went wrong when calling API");
        }
    }
}