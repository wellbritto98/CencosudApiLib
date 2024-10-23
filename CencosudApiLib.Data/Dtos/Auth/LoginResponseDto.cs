using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Auth;

namespace CencosudApiLib.Data.Dtos.Auth;

public class LoginResponseDto
{
    public string Token { get; set; }
    public RefreshToken RefreshToken { get; set; }
}