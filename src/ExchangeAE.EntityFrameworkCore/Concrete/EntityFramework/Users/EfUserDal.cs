using ExchangeAE.Core.DataAccess.EntityFramework;
using ExchangeAE.EntityFrameworkCore.Concrete.EntityFramework.Context;
using ExchangeAE.Users;

namespace ExchangeAE.Users;

public class EfUserDal : EfEntityRepositoryBase<User, ContextDB>, IUserDal
{
}
