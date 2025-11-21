using AutoMapper;
using Blogy.Business.DTOs.ContactDto;
using Blogy.Entity.Entities;

namespace Blogy.Business.Mappings
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<ResultContactDto, UpdateContactDto>().ReverseMap();
        }
    }
}
