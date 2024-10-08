using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Data.Dtos;

public class ReadApiInstanceDto : BaseDto
{

    public int ProjectId {  get; set; }
    public virtual ReadProjectDto? Project { get; set; }

    public int ApiId {  get; set; }
    public virtual ReadApiDto? Api { get; set; }

}