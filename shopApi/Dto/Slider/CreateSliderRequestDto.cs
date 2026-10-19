namespace shopApi.Dto.Slider;

public class CreateSliderRequestDto
{
    public IFormFile Image { get; set; } = null!;
    public bool IsActive { get; set; }
}
