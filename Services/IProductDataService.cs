using ASP.NET_Core_Web_Development_Activity2.Models;

namespace ASP.NET_Core_Web_Development_Activity2.Services
{
    public interface IProductDataService
    {
        List<ProductsModel> GetAllProducts();
        List<ProductsModel> SearchProducts(string searchTerm);
        ProductsModel GetProductById(int id);
        int Insert(ProductsModel product);
        int Delete(ProductsModel product);
        int Update(ProductsModel product);
    }
}
