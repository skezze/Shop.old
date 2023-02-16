using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.GetProducts;
using Shop.Database;
using Shop.UI.Pages.ViewModels;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;

       
        public IEnumerable<ProductViewModel> Products { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Products = new GetProducts(_context).Do();
        }
        
    }
}