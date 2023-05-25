using ExchangeAE.Application.Shared;
using ExchangeAE.Core.Utilities.Results;
using ExchangeAE.Users.Dtos;

namespace ExchangeAE.Users;

public interface IUserService : IBaseService
{
    IDataResult<IList<UserListOutputDto>> GetAllUsers();
    IDataResult<UserOutputDto> GetUserById(int userId);
    IResult Add(InsertUserInputDto input);
    IResult Delete(int UserId);
    IResult Update(UpdateUserInputDto input);

}
