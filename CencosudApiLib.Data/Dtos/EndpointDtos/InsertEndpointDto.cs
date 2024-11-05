using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class InsertEndpointDto : BaseDto
{
    public int ApiId { get; set; }
    public string Path { get; set; }
    public string Method { get; set; }
    public string Description { get; set; }
}