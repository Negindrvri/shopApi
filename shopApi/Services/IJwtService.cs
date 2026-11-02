using shopApi.Entities;

namespace shopApi.Services
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
