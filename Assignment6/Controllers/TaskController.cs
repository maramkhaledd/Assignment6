using Microsoft.AspNetCore.Mvc;
using Assignment_3.Services;
using Assignment_3.Repository;
using Assignment_3.Models;
namespace Assignment_3.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private ITaskServices tasks;

        

        public TaskController(ITaskServices tasks)
        {
            this.tasks = tasks;
        }

        [HttpGet]

        
        public IActionResult getTasks(Tasks task)
        {
            var gettask = tasks.CreateTasks(task);
            return Ok(gettask);
        }

        [HttpGet]
        [Route(("{id}"))]

        public IActionResult GetById(int id)
        {
            var getbyid = tasks.GetTaskById(id);
            return Ok(getbyid);
        }
    }
}
