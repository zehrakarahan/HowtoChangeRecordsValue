using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Records.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       


        [HttpGet("RecordNew")]
        public IActionResult Records(Person person)
        {
            var person1 = new Person("John", "Doe");
            var person2 = person1 with { LastName = "Smith" };
            return Ok(person);
        }

        [HttpGet("RecordChange")]
        public IActionResult Getir(Person person)
        {
            return Ok(person);
        }
    }
}
