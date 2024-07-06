using CQRSPlayground.Mediators.Commands;
using CQRSPlayground.Modals;
using CQRSPlayground.RLL;
using MediatR;

namespace CQRSPlayground.Mediators.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly IProductRLL _productRLL;

        public DeleteProductHandler(IProductRLL productRLL)
        {
            _productRLL = productRLL;   
        }
        public Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productRLL.Deleteproduct(request.Id));
        }
    }
}
