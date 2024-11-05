using System.ComponentModel.DataAnnotations;
using CencosudApiLib.Models.Enums;

namespace CencosudApiLib.Data.Dtos;

    public class UpdateProjectDto : BaseDto
    {
        [Required(ErrorMessage = "O nome do projeto é obrigatório.")]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "O status do projeto é obrigatório.")]
        [EnumDataType(typeof(ProjectStatus), ErrorMessage = "O status deve ser A (Ativo), C (Cancelado) ou D (Desenvolvimento).")]
        public ProjectStatus Status { get; set; }
    }