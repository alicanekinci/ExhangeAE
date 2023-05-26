using ExchangeAE.Contants;
using ExchangeAE.Core.Utilities.Results;
using ExchangeAE.Users.Dtos;

namespace ExchangeAE.Users;

public class UserService : IUserService
{
    private readonly IUserDal _UserDal;

    public UserService(IUserDal UserDal)
    {
        _UserDal = UserDal;
    }

    public IResult Add(InsertUserInputDto input)
    {
        _UserDal.Add(input.ToUserEntity());

        return new SuccessResult(Messages.add);
    }

    public IResult Delete(int userId)
    {
        var UserEntity = _UserDal.Get(User => User.Id == userId);

        _UserDal.Delete(UserEntity);

        return new SuccessResult(Messages.delete);
    }

    public IDataResult<IList<UserListOutputDto>> GetAllUsers()
    {
        var getall = _UserDal.GetAll();
        return new SuccessDataResult<IList<UserListOutputDto>>(getall.ToUserListOutput());
    }

    public IDataResult<UserOutputDto> GetUserById(int UserId)
    {
        var getUser = _UserDal.Get(User => User.Id == UserId);
        return new SuccessDataResult<UserOutputDto>(getUser.ToUserOutput());
    }

    public IResult Update(UpdateUserInputDto input)
    {
        var updateUser = _UserDal.Get(User => User.Id == input.Id);
        _UserDal.Update(updateUser.ToUpdatedUserEntity(input));

        return new SuccessResult(Messages.update);
    }

}