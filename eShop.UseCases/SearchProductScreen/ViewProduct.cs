using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product? Execute(uint id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
