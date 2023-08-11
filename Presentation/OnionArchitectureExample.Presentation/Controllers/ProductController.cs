using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureExample.Application.Abstraction;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitectureExample.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task <IActionResult> GetProductList()
        {

            /*var value =  _productReadRepository.GetList();
            return Ok(value);*/

             _productWriteRepository.Update(new() { Id = Guid.Parse("3b16b5da-179c-45be-81d9-80e4a3068087"),Name="Iphone 14", });
            await _productWriteRepository.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> Id(Guid id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
           var result =  _productWriteRepository.AddAsync(product);
           _productWriteRepository.SaveChanges();
           return Ok(result);
        }
    }
}

