using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Service
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbcontext;
        public ProductService(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        //public AppDbContext dbContext = new AppDbContext();


        public IEnumerable<Product> GetProducts()
        {
            return _dbcontext.Products;
        }


    }
}
