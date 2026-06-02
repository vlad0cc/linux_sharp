using Microsoft.AspNetCore.Mvc;
using DemoApi.Models;

namespace DemoApi.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new List<User>
        {
            new() { Id = 1, Name = "Vlad" },
            new() { Id = 2, Name = "Anna" }
        });
    }
}