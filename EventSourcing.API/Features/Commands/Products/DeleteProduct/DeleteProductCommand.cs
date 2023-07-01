using MediatR;

namespace EventSourcing.API.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
