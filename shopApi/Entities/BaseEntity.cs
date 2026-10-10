namespace shopApi.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateCreate { get; set; } = DateTime.Now;



}
