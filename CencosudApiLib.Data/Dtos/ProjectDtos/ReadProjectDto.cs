using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class ReadProjectDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }

}