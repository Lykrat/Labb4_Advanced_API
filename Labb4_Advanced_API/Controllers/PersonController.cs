using Labb4_Advanced_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_Advanced_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        private IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            return Ok(_personRepository.GetAllPersons());
        }
    }
}
