using Microsoft.AspNetCore.Mvc;
using angular_tutorials_backend.Models;
using angular_tutorials_backend.Services;

namespace angular_tutorials_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonRepository _personRepository;
        public PersonController(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        // POST: api/person
        [HttpPost("create")]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Invalid person data.");
            }
            _personRepository.Add(person);
            Console.WriteLine($"Name: {person.name}, Address: {person.address}");
            return CreatedAtAction(nameof(GetById), new { id = person.Id }, person);

        }
        // GET: api/person
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var person = _personRepository.GetById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}