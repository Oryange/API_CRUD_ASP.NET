using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTodo.Data;
using MyTodo.Models;

namespace MyTodo.Controllers
{
  [ApiController]
  [Route(template: "v1")]
  public class TodoController : ControllerBase
  {
    [HttpGet]
    [Route(template: "todos")]
    public async Task<IActionResult> Get(
        [FromServices] AppDbContext context)
    {
      var todos = await context
      .Todos
      .AsNoTracking()
      .ToListAsync();
      return Ok(todos);
    }
  }
}
