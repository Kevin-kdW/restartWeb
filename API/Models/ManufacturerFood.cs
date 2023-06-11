namespace backend.Models;

public class ManufacturerFood{
  public int Id { get; set; }
  public Food Food { get; set; } = default!;
  public int FoodId { get; set; }
  public Manufacturer Manufacturer { get; set; } = default!;
  public int ManufacturerId { get; set; }
}

