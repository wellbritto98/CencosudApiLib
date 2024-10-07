using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class UpdateProjectDto : BaseDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
}