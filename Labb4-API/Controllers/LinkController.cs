using Labb4_API.Models;
using Labb4_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase {

        private ILinkRepo _linkRepo;
        public LinkController(ILinkRepo linkRepo) {
            this._linkRepo = linkRepo;
        }

        [HttpGet("Hobbies")]
        public IActionResult GetHobbiesPerson(int id) {

            var res = _linkRepo.GetHobbiesPerson(id);
            if (res != null)
                return Ok(res);

            return NotFound($"Person with {id} had no hobbies or person was not found...");
        }

        [HttpGet("Link")]
        public IActionResult GetSingeList(int id) {

            var res = _linkRepo.GetSingleList(id);
            if (res != null)
                return Ok(res);

            return NotFound($"Not found with {id}...");
        }

        [HttpGet("PersonLinks")]
        public IActionResult GetAllSinglePerson(int id) {

            var res = _linkRepo.GetAllSinglePerson(id);
            if (res != null)
                return Ok(res);

            return NotFound($"Person with {id}, no links found");
        }

        [HttpPost]
        public IActionResult CreateLink(int id, string url, int personId, int hobbieId) {

            try {

                LinksHobbies newLink = new LinksHobbies() {
                    Id = id,
                    Link = url,
                    PersonId = personId,
                    HobbiesId = hobbieId,
                };

                return Ok(newLink);

            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add data...");
            }

        }

    }

}
