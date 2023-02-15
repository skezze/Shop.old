using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.GetProducts;
using Shop.Database;
using  Shop.Application.CreateProducts;
using Shop.UI.Pages.ViewModels;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;

        [BindProperty]
        public ProductViewModel Product { get; set; }
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
        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_context).Do(Product);
            return RedirectToPage("Index");
        }
    }
}