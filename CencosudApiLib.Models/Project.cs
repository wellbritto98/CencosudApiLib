using CencosudApiLib.Models;
using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using CencosudApiLib.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudProjectLib.Models;

public class Project : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    [EnumDataType(typeof(ProjectStatus))]
    public ProjectStatus Status { get; set; }
    public ICollection<ApiInstance> ApiInstances { get; set; }




}