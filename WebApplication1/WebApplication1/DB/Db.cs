using WebApplication1.Models;

namespace WebApplication1.DB;

public static class Db
{
    public static List<Pet?> pets = new()
    {
        new Pet("Buddy", "Dog", 15.5, "Brown"),
        new Pet( "Whiskers", "Cat", 8.2, "Gray"),
        new Pet( "Tweety", "Bird", 0.5, "Yellow"),
        new Pet( "Goldie", "Fish", 0.2, "Gold"),
        new Pet( "Spike", "Reptile", 6.8, "Green"),
        new Pet( "Fluffy", "Dog", 12.3, "White"),
        new Pet( "Mittens", "Cat", 7.6, "Black"),
        new Pet( "Polly", "Bird", 0.3, "Green"),
        new Pet( "Nemo", "Fish", 0.1, "Orange"),
        new Pet( "Rex", "Reptile", 9.7, "Brown")
    };

    public static List<VetVisit> Visits = new()
    {
        new VetVisit("2023-01-15", 1, "Regular checkup", 50.0),
        new VetVisit("2023-02-10", 2, "Vaccination", 30.0),
        new VetVisit("2023-03-05", 3, "Wing injury", 70.0),
        new VetVisit("2023-04-20", 4, "Skin infection", 45.0),
        new VetVisit("2023-05-18", 5, "Feeding advice", 25.0),
        new VetVisit("2023-06-12", 6, "Flea treatment", 60.0),
        new VetVisit("2023-07-08", 7, "Teeth cleaning", 80.0),
        new VetVisit("2023-08-25", 8, "Beak trimming", 55.0),
        new VetVisit("2023-09-14", 9, "Water quality check", 35.0),
        new VetVisit("2023-10-30", 10, "Tail injury", 65.0)
    };
}