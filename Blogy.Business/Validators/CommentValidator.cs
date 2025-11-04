using Blogy.Entity.Entities;
using FluentValidation;

namespace Blogy.Business.Validators
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("kullanıcı boş olamaz");
            RuleFor(x => x.BlogId).NotEmpty().WithMessage("blog boş olamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("yorum içeriği  boş olamaz")
                .MaximumLength(250).WithMessage("yorum içeriği 250 karakterden uzun olamaz");
        }
    }
}
