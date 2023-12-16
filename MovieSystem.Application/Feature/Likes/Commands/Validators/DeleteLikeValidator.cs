using FluentValidation;
using MovieSystem.Application.Feature.Likes.Commands.Models;

namespace MovieSystem.Application.Feature.Likes.Commands.Validators
{
    public class DeleteLikeValidator : AbstractValidator<DeleteLikeCommand>
    {
        public DeleteLikeValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.LikeId)
                .NotEmpty().WithMessage("Sorry, Like's id can't be Empty")
                .NotNull().WithMessage("Sorry, Like's id is Required");
        }
    }
}
