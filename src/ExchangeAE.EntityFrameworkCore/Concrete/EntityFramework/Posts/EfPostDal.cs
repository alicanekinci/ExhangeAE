using ExchangeAE.Core.DataAccess.EntityFramework;
using ExchangeAE.EntityFrameworkCore.Concrete.EntityFramework.Context;
using ExchangeAE.Assetss;

namespace ExchangeAE.Assetss;

public class EfAssetsDal : EfEntityRepositoryBase<Assets, ContextDB>, IAssetsDal
{
}
