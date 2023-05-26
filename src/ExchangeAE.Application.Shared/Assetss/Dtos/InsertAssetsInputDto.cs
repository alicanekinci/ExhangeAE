using System.ComponentModel.DataAnnotations;
using ExchangeAE.Application.Shared;
namespace ExchangeAE.Assetss.Dtos;

public class InsertAssetsInputDto : EntityDto
{
    public string Title { get; set; }
    
    [MaxLength(3)]
    public string Symbol { get; set; }
}
