using System.ComponentModel.DataAnnotations;
namespace LendApp.Shared.Modelo;
// ReSharper disable All

public class Prestamo
{
    //Id del prestamo
    [Required(ErrorMessage = "El Id es obligatorio")]
    public int PrestamoId { get; set; }
    
    //Id del cliente | Relación con la clase Cliente
    [Required(ErrorMessage = "El cliente es obligatorio")]
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }
    
    //Monto del prestamo
    [Required(ErrorMessage = "De cuanto es el monto del prestamo?")]
    public float MontoPrestamo { get; set; }
    
    //Interes
    [Required(ErrorMessage = "Cuanto de Intereses le asignaras?")]
    public float Interes { get; set; }
        
    //Tipo de prestamo
    [Required(ErrorMessage = "Cual es el tipo de prestamo?")]
    public string TipoPrestamo { get; set; }

    //Planes de pago
    [Required(ErrorMessage = "Cual es la cantidad de planes de Pagos?")]
    public int PlanPago { get; set; }
        
    //Fecha Otorgada o fecha de expedicion
    [Required(ErrorMessage = "Cual es la fecha de expedicion del prestamo?")]
    public DateTime FechaOtorgamiento { get; set; }

    //Saldo restante
    [Required(ErrorMessage = "Cuanto saldo restante falta?")]
    public float SaldoRestante { get; set; }
    
}