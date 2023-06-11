using backend.Models;
using Bogus;

namespace backend.Data;

public static class Seed
{
  public static List<Manufacturer> GetManufacturers(int count = 10)
  {
    var manufacturerId = 1;
    var faker = new Faker<Manufacturer>()
    .Rules((f, m) =>
    {
      m.Id = manufacturerId++;
      m.Name = f.Company.CompanyName();
      m.Location = f.Address.Country();
    }
    );
    return faker.Generate(count);
  }
  public static List<Vehicle> GetVehicles(List<Manufacturer> manufacturers, int count = 10)
  {
    var vehicleId = 1;
    var faker = new Faker<Vehicle>().Rules((f, v) =>
    {
      v.Id = vehicleId++;
      v.Name = f.Vehicle.Model();
      v.Speed = f.Vehicle.Random.Int(20, 500);
      v.ManufacturerId = f.PickRandom(manufacturers).Id;
    });
    return faker.Generate(count);
  }
  public static List<Food> GetFoods(int count = 10)
  {
    var foodId = 1;
    var foods = new string[]{
      "Burger",
      "Fries",
      "Pizza",
      "Sushi",
      "Coke",
      "Salad",
      "Kebab",
      "Pie",
    };
    var faker = new Faker<Food>().Rules((faker, food) =>
    {
      food.Id = foodId++;
      food.Name = faker.PickRandom(foods);
      food.Description = faker.Lorem.Paragraph();
    });
    return faker.Generate(count);
  }
  public static List<ManufacturerFood> GetManufacturerFoods(List<Manufacturer> manufacturers, List<Food> foods)
  {
    var mfList = new List<ManufacturerFood>();
    var manufacturerFoodId = 0;
    foreach (var food in foods)
    {
      manufacturerFoodId++;
      mfList.Add(new ManufacturerFood{
        Id = manufacturerFoodId,
        FoodId = food.Id,
        ManufacturerId = Random.Shared.Next(manufacturers.Count)+1
      });
    }
    return mfList;
  
  }
}