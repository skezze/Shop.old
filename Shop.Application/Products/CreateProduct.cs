using Shop.Database;
using Shop.Domain.Models;
using Shop.UI.Pages.ViewModels;

namespace Shop.Application.CreateProducts
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;


        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel viewModel)
        {
            _context.Products.Add(new Product
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Value = viewModel.Value
            });
            await _context.SaveChangesAsync();
        }
    }
}
