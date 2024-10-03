using CencosudApiLib.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;

public class ComponentInstance : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    public int EndpointId { get; set; }
    public int ComponentId { get; set; }
}