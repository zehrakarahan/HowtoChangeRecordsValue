using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Records;

namespace dsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("RecordNew")]
        public IActionResult Records(string firstName, string lastName)
        {
            var person1 = new Person("John", "Doe");
            var person2 = person1 with { LastName = "Smith" };



            var person = new Person(firstName, lastName);

            return Ok(person2);
        }


        [HttpGet("RecordChange")]
        public IActionResult Getir(Person person)
        {
            return Ok(person);
        }
    }
}
