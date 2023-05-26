using ExchangeAE.Application.Shared;
namespace ExchangeAE.Users.Dtos;

public class UserOutputDto : EntityDto<int>
{
    #region Properties

    public int UserNo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    #endregion

}
