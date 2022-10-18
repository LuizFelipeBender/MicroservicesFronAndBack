using GeekShopping.ProductAPI.DATA_VO.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
      Task<IEnumerable<ProductVO>> FindAll();

      Task<ProductVO> FindByIdAsync(uint id);  

      Task<ProductVOID> CreateAsync(ProductVOID vo);

      Task<ProductVO> UpdateAsync(ProductVO vo);

      Task<bool> DeleteAsync(uint id);
    }
}