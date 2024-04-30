using Demo.Common.Models;
using Demo.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Demo.DataLayer.Data
{
    public  class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        
        public DbSet<Employeedetail> Employeedetails {  get; set; }
       

    }
} 
