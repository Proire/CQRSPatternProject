using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }   
    }
}
