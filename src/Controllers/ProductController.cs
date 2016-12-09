using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductService.Model;



namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        
    

        // GET api/values/5
        [HttpGet("{id}",Name="GetProduct")]

        [ProducesResponseType(typeof(ProductModel),200)]
        public ProductModel ProductDetails(int id)
        {
            
            ProductModel prod = new ProductModel();
            prod.ProductId = 100;
            prod.ProductName = "iPhone 6s";
            prod.ProductDesc = "Apple iphone 6s Black 60GB";
            prod.ProductPrice = "$700";

            return prod;
        }

       
    }
}
