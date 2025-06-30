using FluentValidation;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Validators
{
    internal sealed class CreateCategoryDtoValidator:AbstractValidator<CategoryCreationDto>
    {
        
        private readonly ApplicationDbContext _dbContext;
        public CreateCategoryDtoValidator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .MinimumLength(8).WithMessage("Name must be at least 8 characters long").MustAsync(BeUniqueCategoryName) 
                .WithMessage("A category with this name already exists.");;
        }
        
        private async Task<bool> BeUniqueCategoryName(string name, CancellationToken cancellationToken)
        {
            // Perform a case-insensitive check in the database
            // We use ToLower() for a case-insensitive comparison that is generally database-agnostic.
            // Some databases might prefer EF.Functions.Like or specific COLLATE clauses for optimal performance.
            var exists = await _dbContext.Categories
                .AnyAsync(c => c.Name.ToLower() == name.ToLower(),cancellationToken);

            return !exists; // Return true if the name does NOT exist (i.e., it's unique)
        }
    }
}