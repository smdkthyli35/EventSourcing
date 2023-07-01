using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Features.Commands.Products.ChangeProductName
{
    public class ChangeProductNameCommand : IRequest<Unit>
    {
        public ChangeProductNameDto ChangeProductNameDto { get; set; }
    }
}
