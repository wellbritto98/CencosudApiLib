using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Data.Dtos;

namespace CencosudProjectLib.Data.Dtos;

public class InsertProjectDto : BaseDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }

}