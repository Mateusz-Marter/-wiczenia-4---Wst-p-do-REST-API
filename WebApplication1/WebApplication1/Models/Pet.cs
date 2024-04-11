using WebApplication1.DB;

namespace WebApplication1.Models;

public class Pet
{
    public int Id { get;}
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string Colour { get;  set; }
    
    private static int _idCount = 0;
    
    public Pet(string name, string category, double weight, string colour)
    {
        Name = name;
        Category = category;
        Weight = weight;
        Colour = colour;
        Id = _idCount + 1;
        _idCount++;
    }
}