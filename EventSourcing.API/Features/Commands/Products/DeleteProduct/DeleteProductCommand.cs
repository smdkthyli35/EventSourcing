using MediatR;

namespace EventSourcing.API.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
