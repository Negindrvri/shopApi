using shopApi.Entities;

namespace shopApi.Dto.product;

public class GetProductByIdResponseDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Name { get; set; } = null!;
    public long Price { get; set; }

    public List<ProductImageResponseDto> Images { get; set; }
}
public class ProductImageResponseDto
{
    public int Id { get; set; }
    public bool IsMain { get; set; }
    public string Url { get; set; } = null!;
}