using Blogy.Business.Services.BlogServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.ViewComponents.BlogsByCategoryComponents
{
    public class _BlogsByCategoryLatesBlogsComponent(IBlogService _blogService): ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs= await _blogService.GetLast3BlogsAsync();
            return View(blogs);
        }
    }
}
