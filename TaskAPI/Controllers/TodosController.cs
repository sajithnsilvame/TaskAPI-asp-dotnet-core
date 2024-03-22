using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        // in here inject the [interface] dependency to the constructor
        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var my_todos = _todoService.AllTodos();

            if (id is null)  return Ok(my_todos);
            my_todos = my_todos.Where(t => t.Id == id).ToList();

            return Ok(my_todos);
        }

        
    }
}
