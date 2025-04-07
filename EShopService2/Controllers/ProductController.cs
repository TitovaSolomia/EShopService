using EShop.Domain.Models;
using EShop.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using EShop.Application.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShopService.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProductController : ControllerBase
{

    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAllProducts());

    // GET api/<ProductController>
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var product = _service.GetProductById(id);
        if (product == null) return NotFound();
        return Ok(product);
    }
    // POST api/<ProductController>
    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        _service.AddProduct(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    // PUT api/<ProductController>
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product product)
    {
        if (id != product.Id) return BadRequest();
        _service.UpdateProduct(product);
        return NoContent();
    }

    // DELETE api/<ProductController>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.DeleteProduct(id);
        return NoContent();
    }

    // EXISTS api/<ProductController>
    [HttpGet("exists/{id}")]
    public ActionResult<bool> Exists(int id)
    {
        var exists = _service.GetProductById(id) != null;
        return Ok(exists);
    }
}