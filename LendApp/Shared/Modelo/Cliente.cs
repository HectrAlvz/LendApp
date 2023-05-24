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
    public DateTime FechaRegistro { get; set; }
    
    //Estatus de pago
    [Required(ErrorMessage = "Cual es tu estatus de pago?")]
    public string EstatusPago { get; set; }
    
    //PrestamoId
    public int? PrestamoId { get; set; }
    public virtual Prestamo? Prestamo { get; set; }
    public virtual ICollection<Pago>? Pagos { get; set; }
}