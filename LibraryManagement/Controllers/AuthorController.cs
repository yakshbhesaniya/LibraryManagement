using LibraryManagement.API.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;
    //    private readonly ApplicationDBContext _context;
        public AuthorController(IAuthorService authorService) 
        {
            this.authorService = authorService;
       //     this._context = _context;
        }
        // GET: api/<AuthorController> Testedokay.
        [HttpGet]
        public async Task<IEnumerable<Author>> Get()
        {
            //  IEnumerable<Author> author = _context.Author;
            // return Ok(author);
            var author = await authorService.GetAll();

            return author;

        }

        // GET api with id/<AuthorController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetByAuthorid(Guid Authorid)
        {
            // return "value";
            // var booktofind = await bookService.GetByid(Bookid);
            // return Book;

            var authorDetailToFound = await authorService.GetByAuthorid(Authorid);

            //  Book book = new Book
            //  {
            //       BookId= Bookid,
            //     BookTitle = book.BookTitle,
            //         Author = Book.Author,
            //        Publication = Book.Publication
            //   };

            return Ok(authorDetailToFound);
        }

        // POST api/<AuthorController> Testedokay.
        [HttpPost]
        public async Task<ActionResult<Author>> AddAuthor([FromBody] AddAuthorDTO input)
        {

            Author author = new Author()
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = input.AuthorName
            };

            var authordata = await authorService.AddAuthor(author); 
            return Ok(authordata);
          //  if (_context.Author == null)
          //  {
           //     return Problem("Entity set 'AppDbContext.Author'  is null.");
         //   }
          //  var author = new Author
          //  {
           //     AuthorId = Guid.NewGuid(),
          //      AuthorName = input.AuthorName
         //   };
         //   _context.Author.Add(author);
         //   await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAuthors", new { id = author.AuthorId }, author);
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
    }
}
