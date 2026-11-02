using shopApi.Entities;

namespace shopApi.Dto.Product;

public class GetProductResponseDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Name { get; set; } = null!;
    public long Price { get; set; }
}