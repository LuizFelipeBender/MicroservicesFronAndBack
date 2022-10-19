using AutoMapper;
using GeekShopping.ProductAPI.Data;
using GeekShopping.ProductAPI.DATA_VO.ValueObjects;
using GeekShopping.ProductAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MysqlContext _context;
        private readonly IMapper _mapper;

        public ProductRepository( MysqlContext context ,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindByIdAsync(uint id)
        {
            Product ?product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVOID> CreateAsync([FromBody]ProductVOID vo)
        {
            Product product =  _mapper.Map<Product>(vo);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVOID>(product);
        }
        public async Task<ProductVO> UpdateAsync([FromBody]ProductVO vo)
        {
            Product product =  _mapper.Map<Product>(vo);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<bool> DeleteAsync(uint id)
        {
            try
            {
              Product ?product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
              if (product == null) return false;
              _context.Products.Remove(product);
               _context.Products.Remove(product);
              await _context.SaveChangesAsync();
              return true;    
            }
            catch (System.Exception)
            {
                
                return false;
            } 
        }
    }
}