using EventSourcing.API.Dtos;
using MediatR;

namespace EventSourcing.API.Features.Queries.Products.GetAllProductsByUserId
{
    public class GetAllProductsByUserIdQuery : IRequest<List<ProductDto>>
    {
        public int UserId { get; set; }
    }
}
