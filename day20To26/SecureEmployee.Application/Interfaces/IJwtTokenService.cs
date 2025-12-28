public interface IJwtTokenService
{
    string GenerateToken(User user);
    string GenerateRefreshToken();
}