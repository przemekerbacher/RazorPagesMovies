using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grocery.Database;
using Grocery.Models;

namespace Grocery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        private readonly GroceryContext _context;

        public ProductsApiController(GroceryContext context)
        {
            _context = context;
        }

        // GET: api/ProductsApi
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        [HttpGet("{category}")]
        public IEnumerable<Product> GetProducts([FromRoute]string category)
        {
            var result = _context.Products.Where(product => product.Categories.Name.Equals(category));

            return result;
        }

        // GET: api/ProductsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}