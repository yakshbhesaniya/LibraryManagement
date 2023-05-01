using LibraryManagement.API.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Security;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            var book = await bookService.GetAll();
             
            return book;
            // book controller get all.
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetByBookid(Guid Bookid)
        {
            // return "value";
            // var booktofind = await bookService.GetByid(Bookid);
            // return Book;

            var bookDetailToFound = await bookService.GetByBookid(Bookid);

      //      Book book = new Book
      //      {
      //          BookId= Bookid,
       //         BookTitle = Book.Title,
       //         Author = Book.Author,
        //        Publication = Book.Publication
         //   };

            return Ok(bookDetailToFound);
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<ActionResult<Book>> Addbook([FromBody] AddBookDTO input)
        {
          //  var Author = await Author.FindAsync(new Guid(input.AuthorId));
          
            Book book = new Book { 
                BookTitle = input.BookTitle,
             //   Author = "Nilay"            //    Publisher = input.PublisherId,
              //  Publication = input.PublicationId
                };
            var bookdata = await bookService.AddBook(book);     
            return Ok(bookdata);
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
