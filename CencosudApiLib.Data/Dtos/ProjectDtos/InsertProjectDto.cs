using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Data.Dtos;
using CencosudApiLib.Models.Enums;

namespace CencosudProjectLib.Data.Dtos
{
    public class InsertProjectDto : BaseDto
    {
        [Required(ErrorMessage = "O nome do projeto é obrigatório.")]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "O status do projeto é obrigatório.")]
        [EnumDataType(typeof(ProjectStatus), ErrorMessage = "O status deve ser A (Ativo), C (Cancelado) ou D (Desenvolvimento).")]
        public ProjectStatus Status { get; set; }
    }
}