using Microsoft.EntityFrameworkCore;
using ExchangeAE.Assetss;
using ExchangeAE.Users;

namespace ExchangeAE.EntityFrameworkCore.Concrete.EntityFramework.Context;

public class ContextDB : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;DataBase=ExchangeAEDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public DbSet<Assets> Assetss { get; set; }
    public DbSet<User> Users { get; set; }
}
