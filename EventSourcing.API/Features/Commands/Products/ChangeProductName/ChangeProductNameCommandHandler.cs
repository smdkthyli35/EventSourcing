﻿using EventSourcing.API.EventStores;
using MediatR;

namespace EventSourcing.API.Features.Commands.Products.ChangeProductName
{
    public class ChangeProductNameCommandHandler : IRequestHandler<ChangeProductNameCommand, Unit>
    {
        private readonly ProductStream _productStream;

        public ChangeProductNameCommandHandler(ProductStream productStream)
        {
            _productStream = productStream;
        }

        public async Task<Unit> Handle(ChangeProductNameCommand request, CancellationToken cancellationToken)
        {
            _productStream.NameChanged(request.ChangeProductNameDto);
            await _productStream.SaveAsync();
            return Unit.Value;
        }
    }
}
