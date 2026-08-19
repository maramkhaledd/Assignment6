using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
namespace Assignment_3.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/tasks")]
    public class TaskV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new {Message = "v2 api"});
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTask(int id)
        {
            return Ok(new { Id = id, Title = "task2", status = "pending", dueDate = DateTime.Now.AddDays(5),createdAt = DateTime.Now });
        }
    }
}
