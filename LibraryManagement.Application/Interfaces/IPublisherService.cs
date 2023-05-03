using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IPublisherService
    {
        public Task<IEnumerable<Publisher>> GetAll();
        public Task<Publisher> GetByPublisherid(Guid PublisherId);
        public Task<Publisher> AddPublisher(Publisher publisher);
        //Task AddBook();
    }
}
