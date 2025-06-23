namespace WebApplication1.Shared.DTOS
{
    public record BlogDto(Guid Id, string Title, Guid? CategoryId = null, string? CategoryName = null);
}
