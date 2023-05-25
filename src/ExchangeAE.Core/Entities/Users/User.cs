using ExchangeAE.Entities;

namespace ExchangeAE.Users;

public class User : Entity<int>
{
    public String Name { get; set; }
    public string Email { get; set; }
    public int Passwprd { get; set; }
}