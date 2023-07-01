using EventSourcing.API.Dtos;
using EventSourcing.API.Features.Commands.Products.ChangeProductName;
using EventSourcing.API.Features.Commands.Products.ChangeProductPrice;
using EventSourcing.API.Features.Commands.Products.CreateProduct;
using EventSourcing.API.Features.Commands.Products.DeleteProduct;
using EventSourcing.API.Features.Queries.Products.GetAllProductsByUserId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventSourcing.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAllListByUserId(int userId)
        {
            return Ok(_mediator.Send(new GetAllProductsByUserIdQuery { UserId = userId }));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            await _mediator.Send(new CreateProductCommand { CreateProductDto = createProductDto });
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> ChaneName(ChangeProductNameDto changeProductNameDto)
        {
            await _mediator.Send(new ChangeProductNameCommand { ChangeProductNameDto = changeProductNameDto });
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> ChanePrice(ChangeProductPriceDto changeProductPriceDto)
        {
            await _mediator.Send(new ChangeProductPriceCommand { ChangeProductPriceDto = changeProductPriceDto });
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommand { Id = id });
            return NoContent();
        }
    }
}
