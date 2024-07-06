using CQRSPlayground.DTOs;
using CQRSPlayground.Modals;
using Microsoft.EntityFrameworkCore;

namespace CQRSPlayground.RLL
{
    public class ProductRLL(ProductDbContext dbcontext) : IProductRLL
    {
        private readonly ProductDbContext _dbcontext = dbcontext;

        public IList<Product> GetProducts()
        {
            IList<Product> products = _dbcontext.Products.ToList();
            return products;
        }

        public Product Insertproduct(string title, int quantity)
        {
            Product newproduct = new Product() { Title = title, Quantity = quantity };
            _dbcontext.Products.Add(newproduct);
            _dbcontext.SaveChanges();
            return newproduct;
        }

        public Product Updateproduct(int id, ProductModal product)
        {
            Product currentproduct = _dbcontext.Products.Find(id);
            if (currentproduct != null)
            {
                currentproduct.Title = product.Title;
                currentproduct.Quantity = product.Quantity;
                _dbcontext.SaveChanges();
            }
            return currentproduct;
        }

        public Product Deleteproduct(int id)
        {
            Product product = _dbcontext.Products.Find(id);
            if (product != null)
            {
                _dbcontext.Remove(product);
                _dbcontext.SaveChanges();
            }
            return product;
        }
    }
}
