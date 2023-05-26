using ExchangeAE.Contants;
using ExchangeAE.Core.Utilities.Results;
using ExchangeAE.Assetss.Dtos;

namespace ExchangeAE.Assetss;

public class AssetsService : IAssetsService
{
    private readonly IAssetsDal _AssetsDal;

    public AssetsService(IAssetsDal AssetsDal)
    {
        _AssetsDal = AssetsDal;
    }

    public IResult Add(InsertAssetsInputDto input)
    {
        if (input.Symbol.Trim().Length != 3)
            return new ErrorResult(true, Messages.ErrorSymbol);

        _AssetsDal.Add(input.ToAssetsInsertEntity());

        return new SuccessResult(Messages.add);
    }

    public IResult Delete(int AssetsId)
    {
        var AssetsEntity = _AssetsDal.Get(Assets => Assets.Id == AssetsId);

        _AssetsDal.Delete(AssetsEntity);

        return new SuccessResult(Messages.delete);
    }

    public IDataResult<IList<AssetsListOutputDto>> GetAllAssetss()
    {
        var getall = _AssetsDal.GetAll();
        return new SuccessDataResult<IList<AssetsListOutputDto>>(getall.ToAssetsListOutputEntity());
    }

    public IDataResult<AssetsOutputDto> GetAssetsById(int AssetsId)
    {
        var getAssets = _AssetsDal.Get(Assets => Assets.Id == AssetsId);
        return new SuccessDataResult<AssetsOutputDto>(getAssets.ToAssetsOutputEntity());
    }

    public IResult Update(UpdateAssetsInputDto input)
    {
        if (input.Symbol.Trim().Length != 3)
            return new ErrorResult(true, Messages.ErrorSymbol);

        var updateAssets = _AssetsDal.Get(Assets => Assets.Id == input.Id);
        _AssetsDal.Update(updateAssets.ToUpdateAssetsEntity(input));

        return new SuccessResult(Messages.update);
    }

}