using System.ComponentModel.DataAnnotations;

namespace cSharpGregsList.Models
{
  public class Car
  {

    public string? Id { get; set; }
    [Required]
    public string? Make { get; set; }
    [Required]
    public string? Model { get; set; }
    [Range(1800, 2022)]
    public int Year { get; set; }

    [Required]
    public int Price { get; set; }
    [Required]

    public string? Description { get; set; }
    [Required]
    public string? ImageUrl { get; set; }

    public bool Pending { get; set; }

    public Car(string? make, string? model, int year, int price, string? description, string? imageUrl, bool pending)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      ImageUrl = imageUrl;
      Pending = pending;
    }
  }
}