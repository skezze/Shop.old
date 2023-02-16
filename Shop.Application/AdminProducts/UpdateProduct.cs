using Shop.Application.Mapper;
using Shop.Database;
using Shop.Domain.Models;
using Shop.UI.Pages.AdminViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminProducts
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;

        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Do(ProductAdminViewModel viewModel)
        {
            var productUpdate = _context.Products.FirstOrDefault(x => x.Id == viewModel.Id); 
            if (productUpdate != null)
            {
                productUpdate = viewModel.ProductAdminViewModelToProduct();
                _context.Products.Update(productUpdate);
                await _context.SaveChangesAsync();
            }
            return productUpdate;

        }


    }
}
