namespace shopApi.Dto.Slider;

public class UpdateSliderRequstDto
{
    public int Id { get; set; }
    public IFormFile? Image { get; set; }
    public bool IsActive { get; set; }
}
