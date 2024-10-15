using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos;

public class ReadComponentDto : BaseDto
{

    public int Id { get; set; }
    public ComponentType Type { get; set; }
    public string Description { get; set; }
    public virtual ICollection<ComponentInstance> ComponentInstances { get; set; }


}