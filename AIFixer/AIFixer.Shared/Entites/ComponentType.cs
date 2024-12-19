using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AIFixer.Shared.Entites;

public class ComponentType
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(50)")]
    [MaxLength(50, ErrorMessage = "El máximo tamaño del campo {0} es {1} caractéres")]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Display(Name = "Nombre")]
    public string Name { get; set; } = null!;
}