using ASP.NET_Core_Web_Development_Activity2.Models;

namespace ASP.NET_Core_Web_Development_Activity2.Services
{
    // : = extends/implements
    // implement interface: IProductDataService into IProductDataService
    public class HardCodedSampleDataRepository : IProductDataService
    {
        // wird hier zur class member variable, damit immer die gleiche liste da ist
        static List<ProductsModel> productsList = new List<ProductsModel>();
        public int Delete(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> GetAllProducts()
        {
            // added if: beschränkt die anzahl an erzeugten items auf 100 damit nicht immer wieder 100+ items zum index addiert werden
            if (productsList.Count == 0)
            {
                // erzeugen einer liste von den productmodels im index
                // ausgelagert um nicht immer random data zu bekommen: List<ProductsModel> productsList = new List<ProductsModel>();
                // neue productmodel instanzen
                productsList.Add(new ProductsModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "Mouse goes *brrr*" });
                productsList.Add(new ProductsModel { Id = 2, Name = "Webcam", Price = 25.99m, Description = "More Zoom Meetings" });
                productsList.Add(new ProductsModel { Id = 3, Name = "Ein Stein", Price = 0.99m, Description = "WTF?" });
                productsList.Add(new ProductsModel { Id = 4, Name = "Notebook", Price = 299.99m, Description = "Superb" });

                // fake data for testing
                for (int i = 0; i < 100; i++)
                {
                    // installed nuget bogus --> fake data
                    productsList.Add(new Bogus.Faker<ProductsModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }

            return productsList;
        }

        public ProductsModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductsModel product)
        {
            throw new NotImplementedException();
        }
    }
}
