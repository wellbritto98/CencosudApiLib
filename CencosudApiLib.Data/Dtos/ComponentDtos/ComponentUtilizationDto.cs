using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos
{
    public class ComponentUtilizationDto : BaseDto
    {
        public List<ReadProjectDto> Projects { get; set; }
        public List<ReadApiDto> Apis { get; set; }
        public List<ReadEndpointDto> Endpoints { get; set; }

    }
}