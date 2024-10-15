using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos;

public class InsertComponentDto : BaseDto
{

    public ComponentType Type { get; set; }
    public string Description { get; set; }

}