using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.Default_Index
{
    public class _DefaultBlogsComponent(ICategoryService _categoryService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() //Invoke içinde asenkron yapmak için invoke async yazmalısın
        {
            var categoriesWithBlogs = await _categoryService.GetCategoriesWithBlogsAsync();
            return View(categoriesWithBlogs);
        }
    }
}
