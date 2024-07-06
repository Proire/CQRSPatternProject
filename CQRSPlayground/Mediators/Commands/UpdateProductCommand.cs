using CQRSPlayground.DTOs;
using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Commands
{
    public class UpdateProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public ProductModal Product { get; set; }
        public UpdateProductCommand(int id, ProductModal product)
        {
            Id = id;
            Product = product;
        }
    }
}
