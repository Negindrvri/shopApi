namespace shopApi.Dto.Slider;

public class GetSliderByIdResponseDto
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime DateCreated { get; set; }
}
