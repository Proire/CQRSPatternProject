using CQRSPlayground.Mediators.Queries;
using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IMediator _mediator;   
        public GetProductByIdHandler(IMediator mediator) 
        {
            _mediator = mediator;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllProductsQuery());
            var output = results.FirstOrDefault(x=>x.Id == request.Id);
            return output;
        }
    }
}   
