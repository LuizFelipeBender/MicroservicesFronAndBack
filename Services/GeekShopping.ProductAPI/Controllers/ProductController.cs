using GeekShopping.ProductAPI.DATA_VO.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       private IProductRepository _repository;

       public ProductController(IProductRepository repository)
       {
        _repository = repository ?? throw new 
            ArgumentNullException(nameof(repository));
       }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> GetAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);        
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(uint id)
        {
            var product = await _repository.FindByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]

        public async Task<ActionResult<ProductVOID>> Create([FromQuery]ProductVOID productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.CreateAsync(productVO);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> UpdateProduct(ProductVO productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.UpdateAsync(productVO);
            return Ok(product);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<ProductVO>> Delete (uint id)
        {
            var status = await _repository.DeleteAsync(id);
            if (!status) return BadRequest();
            return Ok("Produto excluido");
        }

    
    }
}