using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data;

public class Lab7Context : DbContext
{
  public Lab7Context(DbContextOptions<Lab7Context> options)
      : base(options)
  {
  }

  public DbSet<backend.Models.Food> Food { get; set; } = default!;

  public DbSet<backend.Models.Manufacturer> Manufacturer { get; set; } = default!;

  public DbSet<backend.Models.ManufacturerFood> ManufacturerFood { get; set; } = default!;

  public DbSet<backend.Models.Vehicle> Vehicle { get; set; } = default!;

  protected override void OnModelCreating(ModelBuilder builder)
  {
    var manufacturers = Seed.GetManufacturers();
    var vehicles = Seed.GetVehicles(manufacturers);
    var foods = Seed.GetFoods();
    var manufacturerFoods = Seed.GetManufacturerFoods(manufacturers, foods);

    builder.Entity<Manufacturer>().HasData(manufacturers);
    builder.Entity<Vehicle>().HasData(vehicles);
    builder.Entity<Food>().HasData(foods);
    builder.Entity<ManufacturerFood>().HasData(manufacturerFoods);
  }
}
