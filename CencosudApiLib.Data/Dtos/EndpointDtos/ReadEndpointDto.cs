using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models;

namespace CencosudApiLib.Data.Dtos;

public class ReadEndpointDto : BaseDto
{
    public int Id { get; set; }
    public string ApiId { get; set; }
    public virtual Api Api { get; set; }
    public string Path { get; set; }
    public string Method { get; set; }
    public string Description { get; set; }

}