using CQRSPlayground.Mediators.Commands;
using CQRSPlayground.Modals;
using CQRSPlayground.RLL;
using MediatR;

namespace CQRSPlayground.Mediators.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        public UpdateProductHandler(IProductRLL pro)
        {
            Pro = pro;
        }
        public IProductRLL Pro { get ; set;}
        public Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Pro.Updateproduct(request.Id, request.Product));
        }
    }
}
