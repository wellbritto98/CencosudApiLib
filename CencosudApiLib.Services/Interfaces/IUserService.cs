using CencosudApiLib.Data.Dtos.Auth;
using CencosudApiLib.Models.ApiResponse;
using CencosudApiLib.Models.Auth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CencosudApiLib.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApiResponse> RegisterUser(RegisterUserDto dto);
        Task<ApiResponse> LoginUser(LoginUserDto dto);
        Task<ApiResponse> RefreshToken();
        Task<User> GetUserByClaims();
        Task<User> GetUserByEmail(string email);
    }
}
