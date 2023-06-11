namespace backend.Models;

public class Food
{
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public string Description { get; set; } = default!;
  public List<ManufacturerFood> manufacturerFoods { get; set; } = default!;
} 