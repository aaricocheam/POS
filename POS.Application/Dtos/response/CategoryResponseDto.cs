namespace POS.Application.Dtos.response
{
    public class CategoryResponseDto
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public int State { get; set; }
        public int StateCategory { get; set; }
    }
}
