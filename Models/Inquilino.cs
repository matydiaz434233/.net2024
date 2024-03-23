using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_.Net.Models;


public class Inquilino
{
    [Key]
    public int Id_inquilino { get; set; }

    [Required(ErrorMessage = " Nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = " Nombre debe tener como máximo {1} caracteres.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = " Apellido es obligatorio.")]
    [StringLength(50, ErrorMessage = " Apellido debe tener como máximo {1} caracteres.")]
    public string? Apellido { get; set; }

    [Required(ErrorMessage = " Dni es obligatorio.")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "El DNI debe contener exactamente 8 dígitos.")]
    public int Dni { get; set; }

    [Required(ErrorMessage = " Dirección es obligatorio.")]
    [StringLength(100, ErrorMessage = " Dirección debe tener como máximo {1} caracteres.")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = " Teléfono es obligatorio.")]
    [StringLength(20, ErrorMessage = " Teléfono debe tener como máximo {1} caracteres.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = " Correo es obligatorio.")]
    [EmailAddress(ErrorMessage = " Correo no tiene un formato de dirección de correo electrónico válido.")]
    public string? Correo { get; set; }
}
