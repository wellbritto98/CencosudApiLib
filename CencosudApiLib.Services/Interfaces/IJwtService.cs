using CencosudApiLib.Data.Dtos.Auth;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(JwtDto dto);
        bool VerifyJwt(string token);
    }
}
