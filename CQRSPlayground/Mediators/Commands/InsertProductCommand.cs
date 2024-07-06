using CQRSPlayground.DTOs;
using CQRSPlayground.Modals;
using MediatR;

namespace CQRSPlayground.Mediators.Commands
{
    public class InsertProductCommand : IRequest<Product>
    {
        public int Quantity { get; set; }    

        public string Title { get; set; }   

        public InsertProductCommand(int quantity,string title)
        {
            Quantity = quantity; Title = title; 
        }
    }
}
