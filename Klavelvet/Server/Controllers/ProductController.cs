using Klavelvet.Shared.Data_Transfer_Objects.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Klavelvet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPtoducts()
        {
            var productList = new List<ProductDto>();

            var p1 = new ProductDto
            {
                Title = "Corset 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/a/a0/Woman%27s_corset_figured_silk_1730-1740.jpg",
                Price = 1000
            };
            var p2 = new ProductDto
            {
                Title = "Corset 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/7/75/A_pair_of_stays.JPG",
                Price = 500
            };

            var p3 = new ProductDto
            {
                Title = "Corset 3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/0/01/Corset1878taille46_300gram.png",
                Price = 100
            };

            productList.Add(p1);
            productList.Add(p2);
            productList.Add(p3);

            return Ok(productList);
        }
        

    }
}
