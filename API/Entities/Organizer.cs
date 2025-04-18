namespace Data.Entities;

public class Organizer : AbstractUser
{
    public List<Event>? Events { get; set; }
}