using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class UpdateEndpointDto : BaseDto
{
    public string Path { get; set; }
    public string Method { get; set; }
    public string Description { get; set; }
}