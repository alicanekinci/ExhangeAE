using ExchangeAE.Application.Shared;
namespace ExchangeAE.Users.Dtos;

public class UserListOutputDto : EntityDto<int>
{
    public String Name { get; set; }
    public string Email { get; set; }
    public int Passwprd { get; set; }
}
