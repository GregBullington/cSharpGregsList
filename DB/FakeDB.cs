using cSharpGregsList.Models;

namespace cSharpGregsList.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>() {
            new Car("Ford", "Focus ST", 2018, 20000, "Ford Focus ST is one of Fords performance hatchback with a 2 litre EcoBoost engine.", "https://cdn.carbuzz.com/gallery-images/840x560/781000/500/781556.jpg", false),
            new Car("Ford", "Fiesta ST", 2018, 15000, "Ford Fiesta ST is one of Fords performance hatchback with a 2 litre EcoBoost engine.", "https://i.pinimg.com/originals/33/2d/2c/332d2ca2ce6651be17a45b79955085ec.jpg", false),
            new Car("Subaru", "Impreza WRX STI", 2017, 35000, "Subaru Impreza WRX STI is Subarus performance Sedan with a 2 litre turbocharged engine.", "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/wp-content/uploads/2016/10/exterior_mainimage1-626x382.jpg?resize=480:*", true),
            new Car("Nissan", "240SX", 1989, 8000, "Nissan 240SX is one of Nissan's solutions to an affordable sports car.", "https://images.customwheeloffset.com/web-compressed/555379-1-1989-240sx-nissan-se-bc-racing-coilovers-ssr-longchamp-polished.jpg", false),
            new Car("Hennessey", "Venom GT", 2014, 1000000, "Fast as Fu**, Expensive as Fu**!", "https://www.venomgt.com/wp-content/uploads/2014/02/Hennessey_Venom_GT_270.4_mph_KSC_800px-011.jpg", true),
        };
  }
}