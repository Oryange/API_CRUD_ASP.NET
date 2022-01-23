using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyTodo.Models;

namespace MyTodo.Controllers
{
  [ApiController]
  [Route(template: "v1")]
  public class TodoController : ControllerBase
  {
    [HttpGet]
    [Route(template:"todos")]
    public List<Todo> Get()
    {
      return new List<Todo>();
    }
  }
}
