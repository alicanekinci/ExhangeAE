using ExchangeAE.Application.Shared;

namespace ExchangeAE.UserAccounts.Dtos;


public class ResetPasswordDto : EntityDto<Guid>
{
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
    public string ConfirmNewPassword { get; set; }
}