using BlazorWebEC.API.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelCommon;
using System.Linq;

namespace BlazorWebEC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepository.GetProductList();
            var productsDTO = products.Select(x => new ProductDTO() { 
                Name = x.Name,
                Price = x.Price
            });
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductRequest product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productdb = await _productRepository.Create(new Entities.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price

            });
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, productdb);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var product = await _productRepository.GetById(id);
            if (product == null) return NotFound($"{id} is not found");
            return Ok(new ProductDTO()
            {
               Name = product.Name,
               Price = product.Price
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var product = await _productRepository.GetById(id);
            if (product == null) return NotFound($"{id} is not found");

            await _productRepository.Delete(product);
            return Ok(new ProductDTO()
            {
                Name = product.Name,
                Price = product.Price
            });
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductUpdateRequest product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productFromDb = await _productRepository.GetById(id);

            if (productFromDb == null)
            {
                return NotFound($"{id} is not found");
            }
            productFromDb.Name = product.Name;
            productFromDb.Price = product.Price;
            

            var productResult = await _productRepository.Update(productFromDb);

            return Ok(new ProductDTO()
            {
                Name = productResult.Name,
                Price = productResult.Price
            }); ;
        }
    }
}
