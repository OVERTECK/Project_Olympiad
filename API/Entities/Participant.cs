namespace Data.Entities;

public class Participant : AbstractUser
{
    public List<Event>? Events { get; set; }
    
    public List<Participant>? Friends { get; set; }
}