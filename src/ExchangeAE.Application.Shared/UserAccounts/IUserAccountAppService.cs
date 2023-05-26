using ExchangeAE.Core.Utilities.Results;
using ExchangeAE.UserAccounts.Dtos;

namespace ExchangeAE.Application.Shared.Authorizations.UserAccounts;
public interface IUserAccountAppService : IBaseService
{
    IDataResult<List<UserAccountListOutput>> GetAllUsersAccount();
    IDataResult<UserAccountOutputDto> InserUserAccount(InserUserAccountInput input);
    IDataResult<UserAccountOutputDto> UpdateUserAccount(UpdateUserAccountDto input);
    IResult DeleteUserAccountById(EntityDto<Guid> input);
    IResult ChangeEmailAddress(ChangeEmailDto input);
    IResult ResetPassword(ResetPasswordDto input);
    IDataResult<UserAccountOutputDto> GetUserAccountById(EntityDto<Guid> input);
}