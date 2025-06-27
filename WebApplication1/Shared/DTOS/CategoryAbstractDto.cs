using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Shared.DTOS
{
    public abstract record CategoryAbstractDto
    {
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 5 characters.")]
        public string Name{ get; init; }
    }
}