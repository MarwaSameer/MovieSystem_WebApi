using FluentValidation;
using MovieSystem.Application.Feature.Categories.Commands.Models;

namespace MovieSystem.Application.Feature.Likes.Commands.Validators
{
    public class UpdateLikeValidator : AbstractValidator<UpdateLikeCommand>
    {
        public UpdateLikeValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Like's id can't be Empty")
                .NotNull().WithMessage("Sorry, Like's id is Required");

            RuleFor(x => x.LikeValue)
                .NotEmpty().WithMessage("Sorry, Like's Value can't be Empty")
                .NotNull().WithMessage("Sorry, Like's Value is Required");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("Sorry, User's Id can't be Empty")
                .NotNull().WithMessage("Sorry, User's Id is Required");

            RuleFor(x => x.MovieId)
                .NotEmpty().WithMessage("Sorry, Movie's Id can't be Empty")
                .NotNull().WithMessage("Sorry, Movie's Id is Required");
        }
    }
}
