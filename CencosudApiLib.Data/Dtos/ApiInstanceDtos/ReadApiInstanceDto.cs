using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models;
using CencosudProjectLib.Models;

namespace CencosudApiLib.Data.Dtos;

public class ReadApiInstanceDto : BaseDto
{

    public int ProjectId {  get; set; }
    public ReadProjectDto? Project { get; set; }

    public int ApiId {  get; set; }
    public ReadApiDto? Api { get; set; }

}