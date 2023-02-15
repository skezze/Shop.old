using Shop.Database;
using Shop.UI.Pages.ViewModels;

namespace Shop.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<ProductViewModel> Do()
        {
            return _context.Products.ToList().Select(x => new ProductViewModel
            {

                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            }) ;
        }
    }
}
