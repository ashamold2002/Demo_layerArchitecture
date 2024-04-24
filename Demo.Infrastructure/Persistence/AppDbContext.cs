using Demo.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Demo.Infrastructure.Persistence
{
    internal class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        
        internal DbSet<Model1> model {  get; set; }
       

    }
} 
