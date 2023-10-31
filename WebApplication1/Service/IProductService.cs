using WebApplication1.Model;

namespace WebApplication1.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}