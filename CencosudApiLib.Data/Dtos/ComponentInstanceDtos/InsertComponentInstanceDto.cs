using System.ComponentModel.DataAnnotations;

namespace CencosudApiLib.Data.Dtos;

public class InsertComponentInstanceDto : BaseDto
{
    public int Id { get; set; }
    public int EndpointId { get; set; }
    public int ComponentId { get; set; }

}