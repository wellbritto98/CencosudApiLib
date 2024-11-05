using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos;


public class UpdateComponentDto : BaseDto
{
    [Required(ErrorMessage = "O tipo de componente é obrigatório.")]
    [EnumDataType(typeof(ComponentType), ErrorMessage = "O tipo de componente deve ser válido.")]
    public ComponentType Type { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória.")]
    public string Description { get; set; }
}