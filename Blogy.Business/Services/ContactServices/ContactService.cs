using AutoMapper;
using Blogy.Business.DTOs.ContactDto;
using Blogy.DataAccess.Repositories.ContactRepositories;
using Blogy.Entity.Entities;

namespace Blogy.Business.Services.ContactServices
{
    public class ContactService(IContactRepository _contactRepository, IMapper _mapper) : IContactService
    {
        public async Task CreateAsync(CreateContactDto dto)
        {
            var entity = _mapper.Map<Contact>(dto);
            await _contactRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _contactRepository.DeleteAsync(id);
        }

        public async Task<List<ResultContactDto>> GetAllAsync()
        {
            var values = await _contactRepository.GetAllAsync(); // await ekledik
            return _mapper.Map<List<ResultContactDto>>(values);
        }

        public async Task<UpdateContactDto> GetByIdAsync(int id)
        {
            var values = await _contactRepository.GetByIdAsync(id); // await ekledik
            return _mapper.Map<UpdateContactDto>(values);
        }

        public async Task<ResultContactDto> GetSingleByIdAsync(int id)
        {
            var values = await _contactRepository.GetByIdAsync(id); // await ekledik
            return _mapper.Map<ResultContactDto>(values);
        }

        public async Task UpdateAsync(UpdateContactDto dto)
        {
            var entity = _mapper.Map<Contact>(dto);
            await _contactRepository.UpdateAsync(entity);
        }
    }
}