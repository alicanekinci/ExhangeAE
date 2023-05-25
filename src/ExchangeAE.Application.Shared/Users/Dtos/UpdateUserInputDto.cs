using ExchangeAE.Application.Shared;
namespace ExchangeAE.Users.Dtos;

public class UpdateUserInputDto : EntityDto<int>
{
    #region Property
    public String Name { get; set; }
    public string Email { get; set; }
    public int Passwprd { get; set; }
    #endregion
}