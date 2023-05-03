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
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService publisherService;
        public PublisherController(IPublisherService publisherService) 
        {
            this.publisherService = publisherService;
        }
        // GET: api/<PublisherController>
        [HttpGet]
        public async Task<IEnumerable<Publisher>> GetAll()
        {
            var publisher = await publisherService.GetAll();

            return publisher;
        }

        // GET api/<PublisherController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetByPublisherid(Guid PublisherId)
        {
            var publisherDetailToFound = await publisherService.GetByPublisherid(PublisherId);
            return Ok(publisherDetailToFound);
        }

        // POST api/<PublisherController>
        [HttpPost]
        public async Task<ActionResult<Publisher>> AddPublisher([FromBody] AddPublisherDTO input)
        {
            Publisher publisher = new Publisher
            {
                PublisherId = Guid.NewGuid(),
                PublisherName = input.PublisherName
            };
            var publisherdata = await publisherService.AddPublisher(publisher);
            return Ok(publisherdata);

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
