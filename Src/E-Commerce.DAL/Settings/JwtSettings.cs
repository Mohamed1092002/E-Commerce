namespace E_Commerce.DAL.Settings;

public class JwtSettings
{
    public const string jwtSettings = "JwtSettings";
    public string SecretKey { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public int AccessTokenExpiration { get; set; }
}