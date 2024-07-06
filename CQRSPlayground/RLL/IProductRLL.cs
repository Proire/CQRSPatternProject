using CQRSPlayground.DTOs;
using CQRSPlayground.Modals;

namespace CQRSPlayground.RLL
{
    public interface IProductRLL
    {
        Product Deleteproduct(int id);
        IList<Product> GetProducts();
        Product Insertproduct(string title, int quantity);
        Product Updateproduct(int id, ProductModal product);
    }
}