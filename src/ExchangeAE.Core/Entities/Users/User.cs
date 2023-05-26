using System.Text.Json.Serialization;
using ExchangeAE.Entities;

namespace ExchangeAE.Users;

public class User : Entity<int>
{
    #region Properties

    public int UserNo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    #endregion

    #region Navigation Properties

    public Guid? UserAccountId { get; private set; }

    #endregion

}
