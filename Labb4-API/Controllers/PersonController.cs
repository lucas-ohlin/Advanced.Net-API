using Labb4_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb4_API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {

        private IPersonRepo _personRepo;
        public PersonController(IPersonRepo personRepo) {
            this._personRepo = personRepo;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() {
            return Ok(_personRepo.GetAll());
        }

    }

}
