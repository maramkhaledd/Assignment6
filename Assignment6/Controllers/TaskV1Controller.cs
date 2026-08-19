using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Assignment_3.Models;
using Assignment_3.Services;
namespace Assignment_3.Controllers
{
  [ApiController]
  [ApiVersion("1.0", Deprecated = true)]
  [Route("api/v{version:apiVersion}/tasks")]
    public class TaskV1Controller : ControllerBase
    {
        private ITaskServices _taskService;
     
    
        public TaskV1Controller(ITaskServices taskservice) {
            
            _taskService = taskservice;
        
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new { Message = "v1 api" });
        }
  

        [HttpGet]
        [Route(("{id}"))]
        public IActionResult GetbyId(int id)
        {
            return Ok(new { Id = id, Title = "title v1", isCompleted = true });

        }





      
    }
}
