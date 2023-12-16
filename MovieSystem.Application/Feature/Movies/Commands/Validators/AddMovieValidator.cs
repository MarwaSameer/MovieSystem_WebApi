using FluentValidation;
using MovieSystem.Application.Feature.Movies.Commands.Models;

namespace MovieSystem.Application.Feature.Movies.Commands.Validators
{
    public class AddMovieValidator : AbstractValidator<AddMovieCommand>
    {
        public AddMovieValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.MovieName)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required")
                .MinimumLength(3).WithMessage("Movie Name Minimum Length is 3 characters ")
                .MaximumLength(50).WithMessage("Movie Name Maximum Length is 50 characters ");

            RuleFor(x => x.MovieDescription)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required")
                .MaximumLength(500).WithMessage("Movie Description Max length is 500 characters ");

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.VideoUrl)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.Duration)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");

            RuleFor(x => x.ProductionYear)
                .NotEmpty().WithMessage("NotEmpty")
                .NotNull().WithMessage("Required");



        }
    }
}
