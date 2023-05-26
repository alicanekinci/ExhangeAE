using ExchangeAE.Entities;

namespace ExchangeAE.Assetss;

public class Assets : Entity<int>
{
    public string Title { get; set; }
    public string Symbol { get; set; }
}