namespace backend.Models;

public class Manufacturer
{
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public string Location { get; set; } = default!;

  public List<Vehicle> Vehicles { get; set; } = new();
  public List<ManufacturerFood> ManufacturerFoods { get; set; } = default!;
}