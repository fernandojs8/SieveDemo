using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using Sieve.Services;
using SieveDemo.DBContext;

namespace SieveDemo.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDB _db;
        private readonly SieveProcessor _sieveProcessor;

        public ProductController(
            ProductDB db,
            SieveProcessor sieveProcessor)
        {
            _db = db;
            _sieveProcessor = sieveProcessor;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts([FromQuery] SieveModel model)
        {
            var products = _db.ProductDataContext.AsQueryable();
            products = _sieveProcessor.Apply(model, products);
            return Ok(products);
        }
    }
}
