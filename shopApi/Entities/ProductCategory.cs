namespace shopApi.Entities;

public class ProductCategory:BaseEntity
{
    public string Name { get; set; } = null!;
    public int? ParentId { get; set; }
    public ProductCategory? Parent { get; set; }
    public List<ProductCategory>? Children {  get; set; }
    public List<Product> Product {  get; set; }=null!;

}
