namespace backend.Models;

public class Vehicle
{
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public int Speed { get; set; }
  public int ManufacturerId { get; set; }
  public Manufacturer Manufacturer { get; set; } = default!;
}