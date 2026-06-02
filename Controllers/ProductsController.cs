using Microsoft.AspNetCore.Mvc;
using DemoApi.Models;

namespace DemoApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new List<Product>
        {
            new() { Id = 1, Title = "Laptop" },
            new() { Id = 2, Title = "Phone" }
        });
    }
}