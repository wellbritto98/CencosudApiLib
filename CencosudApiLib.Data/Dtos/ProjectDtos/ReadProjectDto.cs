using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos;

public class ReadProjectDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public ProjectStatus Status { get; set; }

}