using ExchangeAE.Application.Shared;
namespace ExchangeAE.Users.Dtos;

public class UpdateUserInputDto : EntityDto<int>
{
   #region Properties

    public int UserNo { get; set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    #endregion

}