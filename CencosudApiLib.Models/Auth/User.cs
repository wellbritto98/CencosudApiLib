using Microsoft.AspNetCore.Identity;


namespace CencosudApiLib.Models.Auth;

public class User : IdentityUser
{
    public string Name { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenExpiredAt { get; set; }
    public DateTime TokenCreatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<Audit> Audits { get; set; }

}