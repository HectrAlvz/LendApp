using System.ComponentModel.DataAnnotations;
namespace LendApp.Shared.Modelo;
// ReSharper disable All

public class Cliente
{
    //Id
    public int ClienteId { get; set; }

    //Nombre
    [Required(ErrorMessage = "No tienes nombre?"), MaxLength(100)]
    public string? NombreCompleto { get; set; }

    //Direccion
    [Required(ErrorMessage = "No tienes direccion?"), MaxLength(100)]
    public string? Direccion { get; set; }

    //Telefono
    [Required(ErrorMessage = "No tienes telefono?"), MaxLength(12), Phone]
    public string? Telefono { get; set; }

    //Fecha de Registro
    [Required(ErrorMessage = "No tienes fecha de registro?")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? FechaRegistro { get; set; }
}