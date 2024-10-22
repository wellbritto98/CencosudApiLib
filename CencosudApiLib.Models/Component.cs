using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using CencosudApiLib.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;

public class Component : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    public ComponentType Type { get; set; }
    public string Description { get; set; }
    public ICollection<ComponentInstance> ComponentInstances { get; set; }

}