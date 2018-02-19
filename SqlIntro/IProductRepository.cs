using System.Collections.Generic;

namespace SqlIntro
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsAndReviews();
        IEnumerable<Product> GetProductsWithReview();
        void DeleteProduct(int id);
        void InsertProduct(Product prod);
        void UpdateProduct(Product prod);
    }
}
