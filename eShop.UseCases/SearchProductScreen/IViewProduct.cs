using eShop.CoreBusiness.Models;

namespace eShop.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {
        Product? Execute(uint id);
    }
}
