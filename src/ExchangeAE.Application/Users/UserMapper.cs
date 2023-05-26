using ExchangeAE.Users.Dtos;

namespace ExchangeAE.Users;

public static class UserMapper
{
    public static User ToUserEntity(this InsertUserInputDto input)
    {
        return new User
        {
            FirstName = input.FirstName,
            LastName = input.LastName,
            Address = input.Address,
            PhoneNumber = input.PhoneNumber
        };
    }

    public static UserOutputDto ToUserOutput(this User user)
    {
        return new UserOutputDto
        {
            Id = user.Id,
            UserNo = user.UserNo,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            PhoneNumber = user.PhoneNumber
        };
    }

    public static User ToUpdatedUserEntity(this User user, UpdateUserInputDto input)
    {
        user.FirstName = input.FirstName;
        user.LastName = input.LastName;

        user.Address = input.Address;
        user.PhoneNumber = input.PhoneNumber;

        return user;
    }

    public static IList<UserListOutputDto> ToUserListOutput(this IList<User> users)
    {
        return users.Select(userListOutput => new UserListOutputDto
        {
            Id = userListOutput.Id,
            UserNo = userListOutput.UserNo,
            FirstName = userListOutput.FirstName,
            LastName = userListOutput.LastName
        }).ToList();
    }
}