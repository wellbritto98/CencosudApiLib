using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Models.Base;

public abstract class BaseEntity
{
    public bool IsDeleted { get; set; } = false;
}
