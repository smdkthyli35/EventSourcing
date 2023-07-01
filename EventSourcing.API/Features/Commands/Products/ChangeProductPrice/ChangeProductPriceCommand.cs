using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Features.Commands.Products.ChangeProductPrice
{
    public class ChangeProductPriceCommand : IRequest
    {
        public ChangeProductPriceDto ChangeProductPriceDto { get; set; }
    }
}
