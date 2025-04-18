namespace Data.Entities;

public abstract class AbstractUser
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Surname { get; set; }
    
    public required string MiddleName { get; set; }
    
    public required string Email { get; set; }
    
    public required string Password { get; set; }
}