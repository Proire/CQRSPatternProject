using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Commands
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public int Id { get; set; } 

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
