using ExchangeAE.Application.Shared;
namespace ExchangeAE.Assetss.Dtos;

public class AssetsOutputDto : EntityDto<int>
{
    #region Property
    public string Title { get; set; }
    #endregion
}
