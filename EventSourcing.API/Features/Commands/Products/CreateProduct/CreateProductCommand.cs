using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public CreateProductDto CreateProductDto { get; set; }
    }
}
