using LibraryManagement.API.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService publicationService;
        public PublicationController(IPublicationService publicationService) 
        {
            this.publicationService = publicationService;
        }
        // GET: api/<PublicationController>
        [HttpGet]
        public async Task<IEnumerable<Publication>> GetAll()
        {
            var publication = await publicationService.GetAll();

            return publication;
        }

        // GET api/<PublicationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publication>> GetByPublicationid(Guid PublicationId)
        {
            var publicationDetailToFound = await publicationService.GetByPublicationid(PublicationId);
            return Ok(publicationDetailToFound);
        }

        // POST api/<PublicationController>
        [HttpPost]
        public async Task<ActionResult<Publication>> AddPublication([FromBody] AddPublicationDTO input)
        {
            Publication publication = new Publication
            {
                PublicationId = Guid.NewGuid(),
                Edition = input.Edition,
                Year = input.Year
            };
            var publicationdata = await publicationService.AddPublication(publication);
            return Ok(publicationdata);


        }

        // PUT api/<PublisherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PublisherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
