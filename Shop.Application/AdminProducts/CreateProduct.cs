

using Shop.Database;
using Shop.Domain.Models;
using Shop.UI.Pages.AdminViewModels;

namespace Shop.Application.AdminProducts
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;


        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductAdminViewModel viewModel)
        {
            _context.Products.Add(new Product
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Value = viewModel.Value
            });
            await _context.SaveChangesAsync();
        }
    }
}
