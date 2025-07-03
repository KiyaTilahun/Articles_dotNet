namespace WebApplication1.Shared.RequestFeatures
{
    public class CategoryParameters:RequestParameters
    {
        public DateTime? MinCreatedAt { get; set; } = DateTime.MinValue;
        public DateTime? MaxCreatedAt { get; set; } = DateTime.MaxValue; // Default to max possible date
        
        public CategoryParameters()=>OrderBy="name";
        public bool ValidCreatedAtRange() => MaxCreatedAt >= MinCreatedAt;
        public string? SearchTerm { get; set; }
    
        
        public bool CheckValidMin() => MinCreatedAt.Value.Year<2020;
    }
}