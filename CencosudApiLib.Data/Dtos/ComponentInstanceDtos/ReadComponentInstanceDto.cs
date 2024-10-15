using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class ReadComponentInstanceDto : BaseDto
{

    public int EndpointId { get; set; }
    public virtual ReadEndpointDto? Endpoint { get; set; }
    public int ComponentId { get; set; }
    public virtual ReadComponentDto? Component { get; set; }


}