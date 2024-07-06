using CQRSPlayground.Mediators.Commands;
using CQRSPlayground.Modals;
using CQRSPlayground.RLL;
using MediatR;

namespace CQRSPlayground.Mediators.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        public InsertProductHandler(IProductRLL pro)
        {
            Pro = pro;
        }

        public IProductRLL Pro { get; set; }

        public Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Pro.Insertproduct(request.Title,request.Quantity));
        }
    }

}
