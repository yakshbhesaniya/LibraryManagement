﻿using LibraryManagement.API.DTOs;
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
        private readonly ApplicationDBContext _context;
        public AuthorController(ApplicationDBContext _context) 
        {
            this._context = _context;
        }
        // GET: api/<AuthorController>
        [HttpGet]
        public async Task<ActionResult<Author>> Get()
        {
            IEnumerable<Author> author = _context.Author;
            return Ok(author);
        }

        // POST api/<AuthorController>
        [HttpPost]
        public async Task<ActionResult<Author>> Post([FromBody] AddAuthorDTO input)
        {
            if (_context.Author == null)
            {
                return Problem("Entity set 'AppDbContext.Author'  is null.");
            }
            var author = new Author
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = input.AuthorName,
                Books = new List<Book>()
            };
            _context.Author.Add(author);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthors", new { id = author.AuthorId }, author);
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
