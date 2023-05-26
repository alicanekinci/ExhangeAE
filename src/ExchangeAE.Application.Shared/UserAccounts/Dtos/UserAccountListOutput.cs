using ExchangeAE.Application.Shared;

namespace ExchangeAE.UserAccounts.Dtos;

public class UserAccountListOutput : EntityDto<int>
{
    #region - Properties

    public string Email { get; set; }

    #endregion
}
