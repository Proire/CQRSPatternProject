using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Queries
{
    public class GetAllProductsQuery : IRequest<IList<Product>>
    {

    }
}
