using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class ReadApiDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string BaseUrl { get; set; }
    public string Version { get; set; }

}