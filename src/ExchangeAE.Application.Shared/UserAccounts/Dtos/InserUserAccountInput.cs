using ExchangeAE.Application.Shared;

namespace ExchangeAE.UserAccounts.Dtos;

public class InserUserAccountInput : EntityDto
{
    #region - Properties

    public string Email { get; set; }
    public string Password { get; set; }

    #endregion
}