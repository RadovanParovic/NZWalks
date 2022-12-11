using FluentValidation;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Validates
{
    public class UpdateWalkDifficultyRequestValidator : AbstractValidator<UpdateWalkDifficultyRequest>
    {
        public UpdateWalkDifficultyRequestValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
