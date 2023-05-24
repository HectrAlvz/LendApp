using System.ComponentModel.DataAnnotations;
namespace LendApp.Shared.Modelo;
// ReSharper disable All

public class Pago
{
    //Id del Pago
    [Required(ErrorMessage = "El Id es obligatorio")]
    public int PagoId { get; set; }
    
    //Id del cliente | Relación con la clase Cliente
    [Required(ErrorMessage = "El cliente es obligatorio")]
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }
    
    //Id del Prestamo | Relación con la clase Prestamo
    [Required(ErrorMessage = "El Prestamo es obligatorio")]
    public int PrestamoId { get; set; }
    public virtual Prestamo? Prestamo { get; set; }
    
    //Fecha del pago
    [Required(ErrorMessage = "Cual es la fecha del pago?")]
    public DateTime FechaPago { get; set; }
    
    //Monto Pagado
    [Required(ErrorMessage = "Cual es el monto pagado?")]
    public float MontoPagado { get; set; }
    
    //Numero de Cuota
    [Required(ErrorMessage = "Cual es el numero de cuota?")]
    public int NumeroCuota { get; set; }
    
}
    