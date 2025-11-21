using Blogy.Business.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class ContactController(IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = _contactService.GetAllAsync();
            return View(values);
        }
    }
}
