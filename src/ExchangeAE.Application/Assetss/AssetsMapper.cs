using ExchangeAE.Assetss.Dtos;

namespace ExchangeAE.Assetss;

public static class AssetsMapper
{
    public static Assets ToAssetsInsertEntity(this InsertAssetsInputDto input)
    {
        return new Assets
        {
            Title = input.Title,
            Symbol = input.Symbol.ToUpper()
        };
    }

    public static IList<AssetsListOutputDto> ToAssetsListOutputEntity(this IList<Assets> assetss)
    {
        return (IList<AssetsListOutputDto>)assetss.Select(assetsList => new AssetsListOutputDto
        {
            Id = assetsList.Id,
            Title = assetsList.Title,
            Symbol = assetsList.Symbol
        }).ToList();
    }

    public static Assets ToUpdateAssetsEntity(this Assets Assets, UpdateAssetsInputDto input)
    {
        Assets.Id = input.Id;
        Assets.Title = input.Title;
        Assets.Symbol = input.Symbol.ToUpper();

        return Assets;
    }
    public static AssetsOutputDto ToAssetsOutputEntity(this Assets assets)
    {
        return new AssetsOutputDto
        {
            Id = assets.Id,
            Title = assets.Title,
            Symbol = assets.Symbol
        };
    }
}
