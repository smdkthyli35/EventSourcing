using EventSourcing.API.EventStores;
using MediatR;

namespace EventSourcing.API.Features.Commands.Products.ChangeProductPrice
{
    public class ChangeProductPriceCommandHandler : IRequestHandler<ChangeProductPriceCommand, Unit>
    {
        private readonly ProductStream _productStream;

        public ChangeProductPriceCommandHandler(ProductStream productStream)
        {
            _productStream = productStream;
        }

        public async Task<Unit> Handle(ChangeProductPriceCommand request, CancellationToken cancellationToken)
        {
            _productStream.PriceChanged(request.ChangeProductPriceDto);
            await _productStream.SaveAsync();
            return Unit.Value;
        }
    }
}
