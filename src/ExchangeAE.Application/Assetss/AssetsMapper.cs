using ExchangeAE.Assetss.Dtos;

namespace ExchangeAE.Assetss;

public static class AssetsMapper
{
    public static Assets ToAssetsInsertEntity(this InsertAssetsInputDto input)
    {
        return new Assets
        {
            Title = input.Title
        };
    }

    public static IList<AssetsListOutputDto> ToAssetsListOutputEntity(this IList<Assets> Assetss)
    {
        return (IList<AssetsListOutputDto>)Assetss.Select(AssetsList => new AssetsListOutputDto
        {
            Id = AssetsList.Id,
            Title = AssetsList.Title
        }).ToList();
    }

    public static Assets ToUpdateAssetsEntity(this Assets Assets, UpdateAssetsInputDto input)
    {
        Assets.Id = input.Id;
        Assets.Title = input.Title;

        return Assets;
    }
    public static AssetsOutputDto ToAssetsOutputEntity(this Assets Assets)
    {
        return new AssetsOutputDto
        {
            Id = Assets.Id,
            Title = Assets.Title
        };
    }
}
