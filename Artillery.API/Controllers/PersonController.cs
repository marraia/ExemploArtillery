using System.Threading.Tasks;
using Artillery.Application.AppPerson.Input;
using Artillery.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Artillery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] PersonInput input)
        {
            return Created("", await _personAppService.InsertAsync(input));
        }
    }
}