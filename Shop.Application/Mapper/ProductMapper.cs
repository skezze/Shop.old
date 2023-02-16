using Shop.Domain.Models;
using Shop.UI.Pages.AdminViewModels;
using Shop.UI.Pages.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Mapper
{
    public static class ProductMapper
    {
        public static ProductViewModel ProductToProductViewModel(this Product product)
        {
            return new ProductViewModel
            {
                Description = product.Description,
                Name = product.Name,
                Value = product.Value
            };

        }
        public static ProductAdminViewModel ProductToProductAdminViewModel(this Product product)
        {
            return new ProductAdminViewModel
            {
                Id = product.Id,
                Description = product.Description,
                Name = product.Name,
                Value = product.Value,
                Stock = product.Stock
            };
        }
        public static Product ProductAdminViewModelToProduct(this ProductAdminViewModel viewModel)
        {
                return new Product
                {
                    Id = viewModel.Id,
                    Description = viewModel.Description,
                    Name = viewModel.Name,
                    Value = viewModel.Value,
                    Stock = viewModel.Stock
                };

        }
    }
}
