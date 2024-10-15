using CencosudApiLib.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;
[PrimaryKey(nameof(EndpointId), nameof(ComponentId))]
public class ComponentInstance : BaseEntity
{
    [Column(Order = 0)]
    [ForeignKey("Endpoint")]
    public int EndpointId { get; set; }
    [Column(Order = 1)]
    [ForeignKey("Component")]
    public int ComponentId { get; set; }
    public virtual Endpoint Endpoint { get; set; }
    public virtual Component Component { get; set; }
}