using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using DenizKabacelik.JwtProje.WebApi.CustomFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using Microsoft.AspNetCore.Diagnostics;

namespace DenizKabacelik.JwtProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IMapper _mapper;
            
            public ProductsController(IProductService productService,IMapper mapper)
        {

            _mapper = mapper;
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


         
                await _productService.Add(_mapper.Map<Product>(productAddDto));
                return Created("", productAddDto);

          
        
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidId<Product>))]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto) {

            await _productService.Update(_mapper.Map<Product>(productUpdateDto));
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


        [Route("/Error")]

        public IActionResult Error() {


            var errorInfo=HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            return Problem(detail: "Api'de bir hata oluştu,en kısa zamanda düzeltilecek ");    
        }
    }
    
}
