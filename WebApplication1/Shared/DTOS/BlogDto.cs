namespace WebApplication1.Shared.DTOS
{
    public record BlogDto(Guid Id, string Title, string Author,Guid? CategoryId = null, string? CategoryName = null);
}
