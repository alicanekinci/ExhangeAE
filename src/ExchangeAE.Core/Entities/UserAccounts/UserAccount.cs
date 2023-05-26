using ExchangeAE.Entities;

namespace ExchangeAE.UserAccounts;

public class UserAccount : Entity<int>
{
    #region Properties
    
    public string Email { get; private set; }
    public string Password { get; private set; }

    #endregion
}