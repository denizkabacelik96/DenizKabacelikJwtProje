using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using DenizKabacelik.JwtProje.WebApi.CustomFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DenizKabacelik.JwtProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;
            public ProductsController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]
        public async Task <IActionResult> GetAll()
        {

            var products = await _productService.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Product>))]
        public async Task<IActionResult> GetById(int id) {

            var product = await _productService.GetById(id);
            return Ok(product);
        }


        [HttpPost]
        [ValidModel]
        public async Task<IActionResult> Add(ProductAddDto productAddDto) {


         
                await _productService.Add(new Product { Name = productAddDto.Name });
                return Created("", productAddDto);

          
        
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidId<Product>))]
        public async Task<IActionResult> Update(Product product) {

            await _productService.Update(product);
            return NoContent();
        
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {

            await _productService.Remove(new Product() { Id=id});
            return NoContent(); 
        
        }

        [HttpGet("test/{id }")]
        [ServiceFilter(typeof(ValidId<AppUser>))]
        public  IActionResult Test(int id)
        {

            return Ok();

        }
    }
    
}
