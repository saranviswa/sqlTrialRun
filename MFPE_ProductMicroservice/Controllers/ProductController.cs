using MFPE_ProductMicroservice.Models;
using MFPE_ProductMicroservice.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFPE_ProductMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ProductController));
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _log4net.Info("Logger initiated");
        }
        // GET: api/<ProductController>
        [HttpGet]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        public IActionResult Get()
        {


            try
            {



                var product = _productRepository.GetAllProduct();

                if (product == null)
                {
                    _log4net.Error("Logged inside get method");
                    return NotFound("The product list is empty");
                }
                _log4net.Info("Retuned successfully from getall action method");
                return Ok(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        public ActionResult GetById(int id)
        {
            var product = _productRepository.SearchProductByID(id);
            if (product == null)
            {
                // _log4net.Error(Constant.ProductNotFoundById);
                return NotFound("There is no product item with the given id");
            }

            return Ok(product);
        }

        [HttpGet("GetByName/{name}")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetbyName(string name)
        {
            //_log4net.Info("Searching product by productName");
            var product = _productRepository.SearchProductByName(name);
            if (product == null)
            {
                //_log4net.Error(Constant.ProductNotFoundByName);
                return NotFound("There is no product with the given name");
            }
            return Ok(product);
        }

        // POST api/<ProductController>
        [HttpPost("AddProductRating")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult PostAddRating(RatingData data)
        {

            {
                //_log4net.Info(Constant.ProductRating);
                if (_productRepository.AddProductRating(data.Id, data.Rating) <= 0)
                {
                    return BadRequest("Unable to add ratings to the product");
                }
            }
            return NoContent();

        }


    }
}
