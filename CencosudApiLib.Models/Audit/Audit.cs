using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;
using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace CencosudApiLib.Models;
[PrimaryKey(nameof(Id), nameof(Type), nameof(Entity))]
public class Audit : BaseEntity
{
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column(Order = 1)]
    public string EntityName { get; set; }
    [Column(Order = 2)]
    public int EntityId { get; set; }
    public string Action { get; set; }
    public string Changes { get; set; }
    [ForeignKey("User")]
    public string Performed_By { get; set; }
    public virtual User User { get; set; }
    public DateTime Performed_At { get; set; } = DateTime.Now;


}
