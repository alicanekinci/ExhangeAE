using ExchangeAE.Application.Shared;

namespace ExchangeAE.UserAccounts.Dtos;
public class UserAccountOutputDto : EntityDto<Guid>
{
    #region - Properties

    public string Email { get; set; }
    public string Password { get; set; }

    #endregion
}