using CQRSPlayground.DTOs;
using CQRSPlayground.Mediators.Commands;
using CQRSPlayground.Mediators.Queries;
using CQRSPlayground.Modals;
using CQRSPlayground.RLL;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRSPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _mediator;

        public ProductsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _mediator.Send(new GetProductByIdQuery(id));
        }

        [HttpPost]
        public async Task<Product> Post([FromBody] ProductModal product)
        {
                return await _mediator.Send(new InsertProductCommand(product.Quantity, product.Title));
        }

        [HttpPut("{id}")]
        public async Task<Product> Put([FromBody] ProductModal product, int id)
        {
            return await _mediator.Send(new UpdateProductCommand(id,product));
        }

        [HttpDelete("{id}")]
        public async Task<Product> Delete(int id)
        {
            return await _mediator.Send(new DeleteProductCommand(id));
        }
    }
}
