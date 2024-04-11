namespace WebApplication1.Models;

public class VetVisit
{
    public string Date { get; set; }
    public int PetId { get; set; }
    public string Note { get; set; }
    public double Price { get; set; }


    public VetVisit(string date, int petId, string note, double price)
    {
        Date = date;
        PetId = petId;
        Note = note;
        Price = price;
    }
}