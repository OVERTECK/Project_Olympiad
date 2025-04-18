namespace Data.Entities;

public class Event
{
    public Guid Id { get; set; }
    
    public required string Title { get; set; }

    public string? Description { get; set; }
    
    public required Organizer Organizer { get; set; }
    
    public required List<Format> Formats { get; set; }
    
    public required string Place { get; set; }
    
    public DateTime DateTimeStart { get; set; }
    
    public DateTime Duration { get; set; }

    public List<string>? TitleImage { get; set; }
}