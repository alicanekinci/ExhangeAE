using System.Text.Json.Serialization;

namespace ExchangeAE.Authentication;
public class JwtSettings
{
    [JsonPropertyName("Secret")]
    public string Secret { get; set; }

    [JsonPropertyName("Issuer")]
    public string Issuer { get; set; }

    [JsonPropertyName("Audience")]
    public string Audience { get; set; }

    [JsonPropertyName("AccessTokenExpiration")]
    public int AccessTokenExpiration { get; set; }

    [JsonPropertyName("RefreshTokenExpiration")]
    public int RefreshTokenExpiration { get; set; }
}