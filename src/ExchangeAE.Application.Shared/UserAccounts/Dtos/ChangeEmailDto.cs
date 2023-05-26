using ExchangeAE.Application.Shared;

namespace ExchangeAE.UserAccounts.Dtos;

public class ChangeEmailDto : EntityDto<Guid>
{
    public string Email { get; set; }
}