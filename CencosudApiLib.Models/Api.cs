using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;

public class Api : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string BaseUrl { get; set; }
    public string Version { get; set; }
    public ICollection<ApiInstance> ApiInstances { get; set; }
    public ICollection<Endpoint> Endpoints { get; set; }

}