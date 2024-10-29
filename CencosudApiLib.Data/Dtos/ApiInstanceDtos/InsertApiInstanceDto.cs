using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class InsertApiInstanceDto : BaseDto
{
    public int ProjectId {  get; set; }
    public int ApiId {  get; set; }

}