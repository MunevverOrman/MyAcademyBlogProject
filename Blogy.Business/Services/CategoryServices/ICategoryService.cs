using Blogy.Business.DTOs.CategoryDtos;

namespace Blogy.Business.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>>GetAllAsync(); //listeleme

        Task<List<ResultCategoryDto>> GetCategoriesWithBlogsAsync(); 

        Task<UpdateCategoryDto>GetByIdAsync(int id); //id ye göre getirme

        Task CreateAsync(CreateCategoryDto categoryDto);

        Task UpdateAsync(UpdateCategoryDto categoryDto);

        Task DeleteAsync(int id);

    }
}
