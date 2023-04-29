﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        public BookController(IBookService bookingService) 
        {
            this.bookService = bookService;
        }
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var book = await bookService.GetAll();
             
            return book;
            // book controller get all.
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
