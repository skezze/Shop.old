using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminProducts;
using Shop.Database;
using Shop.UI.Pages.AdminViewModels;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            return Ok(new GetProducts(_context).Do());
        }
        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(new GetProduct(_context).Do(id));
        }
        [HttpPost("products")]
        public IActionResult CreateProduct([FromBody] ProductAdminViewModel viewModel)
        {
            return Ok(new CreateProduct(_context).Do(viewModel));
        }
        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct( int id)
        {
            return Ok(new DeleteProduct(_context).Do(id));
        }
        [HttpPut("products")]
        public IActionResult UpdateProduct([FromBody] ProductAdminViewModel viewModel)
        {
            return Ok(new UpdateProduct(_context).Do(viewModel));
        }
    }
}
