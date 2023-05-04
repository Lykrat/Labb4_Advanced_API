using Labb4_Advanced_API.Models;
using Labb4_Advanced_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_Advanced_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : Controller
    {
        private ILinksRepository _linksRepository;

        public LinksController(ILinksRepository linksRepository)
        {
            this._linksRepository = linksRepository;
        }

        [HttpGet("Insert Id to get Interests")]
        public IActionResult GetInterestSinglePerson(int id)
        {
            var result = _linksRepository.GetInterestSinglePerson(id);
            if(result!= null)
            {
                return Ok(result);
            }
            return NotFound($"There were no interests for the person with the id {id}");
        }
        [HttpGet("Insert Id for link")]
        public IActionResult GetSingleList(int id)
        {
            var result = _linksRepository.GetSingleList(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        [HttpGet("Insert Id for all links")]
        public IActionResult GetAllSingelPerson(int id)
        {
            var result =_linksRepository.GetAllSinglePerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound($"There were no links for the person with the id {id}");
        }
        [HttpPost]
        public IActionResult AddNewLink(LinksIntrests newList)
        {
            try
            {
                if (newList == null)
                {
                    return BadRequest();
                }
                var CreatedList = _linksRepository.Add(newList);
                return CreatedAtAction(nameof(GetSingleList), new { id = CreatedList.ID }, CreatedList);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "internal error in server");
            }
        }
    }
}
