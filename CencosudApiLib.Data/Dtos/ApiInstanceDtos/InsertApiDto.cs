using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class InsertApiInstanceDto : BaseDto
{
    public string ProjectId {  get; set; }
    public string ApiId {  get; set; }

}