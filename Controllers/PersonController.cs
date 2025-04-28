using Microsoft.AspNetCore.Mvc;
using angular_tutorials_backend.Models;

namespace angular_tutorials_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // POST: api/person
        [HttpPost("create")]
        public IActionResult CreateOrder([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Invalid person data.");
            }
            Console.WriteLine($"Name: {person.name}, Address: {person.address}");
            // Here you would typically save the person to a database
            // For this example, we'll just return the person back
            return Ok(person);
        }
    }
}