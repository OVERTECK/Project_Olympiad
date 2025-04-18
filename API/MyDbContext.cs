using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace API;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; }
    
    public DbSet<Format> Formats { get; set; }
    
    public DbSet<Organizer> Organizers { get; set; }
    
    public DbSet<Participant> Participants { get; set; }
    
    public DbSet<Role> Roles { get; set; }
}