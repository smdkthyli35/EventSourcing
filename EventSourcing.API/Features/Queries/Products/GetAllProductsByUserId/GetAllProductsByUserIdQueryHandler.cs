using EventSourcing.API.Dtos;
using EventSourcing.API.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EventSourcing.API.Features.Queries.Products.GetAllProductsByUserId
{
    public class GetAllProductsByUserIdQueryHandler : IRequestHandler<GetAllProductsByUserIdQuery, List<ProductDto>>
    {
        private readonly AppDbContext _appDbContext;

        public GetAllProductsByUserIdQueryHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var products = await _appDbContext.Products.Where(x => x.UserId == request.UserId).ToListAsync();

            return products.Select(x => new ProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                UserId = x.UserId
            }).ToList();
        }
    }
}
