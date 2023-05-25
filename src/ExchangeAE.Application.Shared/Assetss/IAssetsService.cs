using ExchangeAE.Application.Shared;
using ExchangeAE.Core.Utilities.Results;
using ExchangeAE.Assetss.Dtos;

namespace ExchangeAE.Assetss;

public interface IAssetsService : IBaseService
{
    IDataResult<IList<AssetsListOutputDto>> GetAllAssetss();
    IDataResult<AssetsOutputDto> GetAssetsById(int AssetsId);
    IResult Add(InsertAssetsInputDto input);
    IResult Delete(int AssetsId);
    IResult Update(UpdateAssetsInputDto input);

}
