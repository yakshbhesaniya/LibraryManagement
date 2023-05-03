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
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository publisherRepository;

    public PublisherService(IPublisherRepository publisherRepository)
    {
        this.publisherRepository = publisherRepository;
    }
        
    public async Task<IEnumerable<Publisher>> GetAll()
    {
        return await publisherRepository.GetAll();
    }

    async Task<Publisher> IPublisherService.GetByPublisherid(Guid Publisherid)
    {
        return await publisherRepository.GetByPublisherid(Publisherid);
    }

    public async Task<Publisher> AddPublisher(Publisher publisher)
    {
        return await publisherRepository.AddPublisher(publisher);
    }

    }
}
