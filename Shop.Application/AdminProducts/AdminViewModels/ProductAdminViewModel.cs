using Shop.Domain.Models;

namespace Shop.UI.Pages.AdminViewModels
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public ICollection<Stock> Stock { get; set; }
    }
}
