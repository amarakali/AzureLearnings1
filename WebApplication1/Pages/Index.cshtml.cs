using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Service;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel

    {
        public List<Product> Products;
        private readonly IProductService _productService;
        public IndexModel(IProductService productService)
        {
               _productService = productService;
        }
        
        public void OnGet()
        {
            //ProductService productService = new ProductService();
            Products = _productService.GetProducts().ToList();
        }
    }
}