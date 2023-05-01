using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        this.bookRepository = bookRepository;
    }

    public async Task<IEnumerable<Book>> GetAll()
    {
        return await bookRepository.GetAll();
    }

    async Task<Book> IBookService.GetByBookid(Guid Bookid)
    {
        return await bookRepository.GetByBookid(Bookid);
    }

    public async Task<Book> AddBook(Book book)
    {
        return await bookRepository.AddBook(book);
    }
    }
}
