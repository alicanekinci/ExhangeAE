using ExchangeAE.Users.Dtos;

namespace ExchangeAE.Users;

public static class UserMapper
{
    public static User ToUserInsertEntity(this InsertUserInputDto input)
    {
        return new User
        {
            Name = input.Name,
            Email = input.Email,
            Passwprd = input.Passwprd
        };
    }

    public static IList<UserListOutputDto> ToUserListOutputEntity(this IList<User> Users)
    {
        return (IList<UserListOutputDto>)Users.Select(userList => new UserListOutputDto
        {
            Id = userList.Id,
            Name = userList.Name,
            Email = userList.Email
        }).ToList();
    }

    public static User ToUpdateUserEntity(this User User, UpdateUserInputDto input)
    {
        User.Id = input.Id;
        User.Name = input.Name;
        User.Email = input.Email;

        return User;
    }
    public static UserOutputDto ToUserOutputEntity(this User User)
    {
        return new UserOutputDto
        {
            Id = User.Id,
            Name = User.Name,
            Email = User.Email
        };
    }
}
