using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;
using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;

namespace CencosudApiLib.Models.Audit;

public class Audit : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    public string Type { get; set; }
    public string Entity { get; set; }
    public string Action { get; set; }
    public string Changes { get; set; }
    [ForeignKey("User")]
    public string Performed_By { get; set; }
    public virtual User User { get; set; }
    public DateTime Performed_At { get; set; } = DateTime.Now;


}
