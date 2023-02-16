using Shop.Database;
using Shop.UI.Pages.AdminViewModels;

namespace Shop.Application.AdminProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<ProductAdminViewModel> Do()
        {
            return _context.Products.ToList().Select(x => new ProductAdminViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            }) ;
        }
    }
}
