using Blogy.Business.DTOs.BlogDtos;
using FluentValidation;

namespace Blogy.Business.Validators.BlogValidators
{
    public class CreateBlogValidator:AbstractValidator<CreateBlogDto>
    {
        public CreateBlogValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(x => x.CoverImage).NotEmpty().WithMessage("Kapak resmi  boş bırakılamaz");
            RuleFor(x => x.BlogImage1).NotEmpty().WithMessage("blog resmi 1  boş bırakılamaz");
            RuleFor(x => x.BlogImage2).NotEmpty().WithMessage("Blog resmi 2 boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");

        }
    }
}
