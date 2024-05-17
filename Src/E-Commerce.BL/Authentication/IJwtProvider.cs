namespace E_Commerce.BL.Authentication;

public interface IJwtProvider
{
    string GenerateJwtToken(string email, string role);
}