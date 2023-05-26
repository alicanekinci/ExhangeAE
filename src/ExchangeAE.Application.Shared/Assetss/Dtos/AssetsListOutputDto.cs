using ExchangeAE.Application.Shared;
namespace ExchangeAE.Assetss.Dtos;

public class AssetsListOutputDto : EntityDto<int>
{
    public string Title { get; set; }
    public string Symbol { get; set; }
}
