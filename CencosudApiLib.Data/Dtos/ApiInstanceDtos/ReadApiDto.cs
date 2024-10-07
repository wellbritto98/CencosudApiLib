using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class ReadApiInstanceDto : BaseDto
{
    public string ProjectId {  get; set; }
    public string ApiId {  get; set; }

}