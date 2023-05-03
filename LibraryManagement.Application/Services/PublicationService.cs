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
    public class PublicationService : IPublicationService
    {
        private readonly IPublicationRepository publicationRepository;

    public PublicationService(IPublicationRepository publicationRepository)
    {
        this.publicationRepository = publicationRepository;
    }
        
    public async Task<IEnumerable<Publication>> GetAll()
    {
        return await publicationRepository.GetAll();
    }

    async Task<Publication> IPublicationService.GetByPublicationid(Guid Publicationid)
    {
        return await publicationRepository.GetByPublicationid(Publicationid);
    }

    public async Task<Publication> AddPublication(Publication publication)
    {
        return await publicationRepository.AddPublication(publication);
    }

    }
}
