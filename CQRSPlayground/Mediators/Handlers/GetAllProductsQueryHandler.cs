using CQRSPlayground.Mediators.Queries;
using CQRSPlayground.Modals;
using CQRSPlayground.RLL;
using MediatR;

namespace CQRSPlayground.Mediators.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IList<Product>>
    {
        private readonly IProductRLL _productsRepository;

        public GetAllProductsQueryHandler(IProductRLL productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public Task<IList<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = Task.FromResult(_productsRepository.GetProducts());
            return products;
        }
    }
}
