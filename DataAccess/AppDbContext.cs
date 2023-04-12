using CapstoneProjects.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProjects.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        //default
    }


    //CORRESPONDING TABLES
    public DbSet<Department> Departments { get; set; }
}

