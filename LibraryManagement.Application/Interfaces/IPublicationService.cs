using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IPublicationService
    {
        public Task<IEnumerable<Publication>> GetAll();
        public Task<Publication> GetByPublicationid(Guid PublicationId);
        public Task<Publication> AddPublication(Publication publication);
        //Task AddBook();
    }
}
