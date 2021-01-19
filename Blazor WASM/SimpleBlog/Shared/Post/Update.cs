using FluentValidation;
using MediatR;

namespace ASimpleBlogStarter.Shared.Post
{
    public class Update
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator(ISlugValidator slugValidator)
            {
                RuleFor(c => c.Title).NotEmpty();
                RuleFor(c => c.Body).NotEmpty();
            }
        }
    }
}