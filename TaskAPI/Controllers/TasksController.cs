using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] {"task 1", "task 2", "task 2", "task 3"  };
            return Ok(tasks);
            
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask() 
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTask()
        {
            return Ok();
        }

        
    }
}
