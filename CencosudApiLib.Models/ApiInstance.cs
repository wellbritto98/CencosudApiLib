using CencosudApiLib.Models.Auth;
using CencosudApiLib.Models.Base;
using CencosudProjectLib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CencosudApiLib.Models;
[PrimaryKey(nameof(ProjectId), nameof(ApiId))]
public class ApiInstance : BaseEntity
{

    [Column(Order = 0)]
    [ForeignKey("Project")]
    public int ProjectId {  get; set; }
    public virtual Project Project { get; set; }

    [Column(Order = 1)]
    [ForeignKey("Api")]
    public int ApiId {  get; set; }
    public virtual Api Api { get; set; }

}