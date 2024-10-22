using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;

public class Endpoint : BaseEntity
{
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    [ForeignKey("Api")]
    public int ApiId { get; set; }
    public virtual Api Api { get; set; }
    public string Path { get; set; }
    public string Method { get; set; }
    public string Description { get; set; }
     public ICollection<ComponentInstance> ComponentInstances { get; set; }

}