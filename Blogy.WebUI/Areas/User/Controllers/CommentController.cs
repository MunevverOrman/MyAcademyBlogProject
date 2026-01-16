using Blogy.Business.DTOs.CommentDtos;
using Blogy.Business.Services.CommentServices;
using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Content))
                return RedirectToAction("BlogDetails", "Blog", new { area = "", id = dto.BlogId });

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return RedirectToAction("Index", "Login", new { area = "" });

            dto.UserId = user.Id;

            await _commentService.CreateAsync(dto);

            return RedirectToAction("BlogDetails", "Blog", new { area = "", id = dto.BlogId });
        }


        [HttpGet]
        public async Task<IActionResult> MyComments()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return RedirectToAction("Index", "Login", new { area = "" });

            var values = await _commentService.GetCommentsByUserIdAsync(user.Id);
            return View(values);
        }

    }
}
