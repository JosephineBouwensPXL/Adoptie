using CildAdoptie.Models;
using CildAdoptie.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CildAdoptie.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptionController : ControllerBase
    {
        private readonly IChildRepository _childRepository;

        public AdoptionController(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AdoptionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _childRepository.Add(request);
            return CreatedAtAction(nameof(Create), new { id = request.Id }, request);

        }

    }
}
