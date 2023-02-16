using Microsoft.EntityFrameworkCore;
using Shop.Application.Mapper;
using Shop.Database;
using Shop.Domain.Models;
using Shop.UI.Pages.AdminViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminProducts
{
    public class GetProduct
    {
        private ApplicationDbContext _context;

        public GetProduct(ApplicationDbContext context)
        {
            _context = context;
        }
        public async  Task<ProductAdminViewModel> Do(int id)
        { 
            var product = await _context.Products.FirstOrDefaultAsync(x=> x.Id == id);
            return product.ProductToProductAdminViewModel();
        }
    }
}
