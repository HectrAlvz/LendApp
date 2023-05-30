using System.ComponentModel.DataAnnotations;
namespace LendApp.Shared.Modelo;
// ReSharper disable All

public class Prestamo
{
    //Id del prestamo
    [Required(ErrorMessage = "El Id es obligatorio")]
    public int PrestamoId { get; set; }
    
    //Id del cliente | Solo puede haber un prestamo por cliente
    [Required(ErrorMessage = "El Id del cliente es obligatorio")]
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }

    // Nombre del cliente
    [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
    public string? NombreCliente { get; set; }

    //Monto Prestado
    [Required(ErrorMessage = "Cual es el monto prestado?")]
    public float MontoPrestado { get; set; }
    
    // //Monto a pagar por cuota
    // [Required(ErrorMessage = "Cual es el monto a pagar por cuota?")]
    // public float MontoCuota { get; set; }
    
    //Interes
    [Required(ErrorMessage = "Cuanto de Intereses le asignaras?")]
    public float Interes { get; set; }
        
    //Tipo de prestamo
    [Required(ErrorMessage = "Cual es el tipo de prestamo?")]
    public string? TipoPrestamo { get; set; }

    //Planes de pago
    [Required(ErrorMessage = "Cual es la cantidad de planes de Pagos?")]
    public int PlanesPago { get; set; }
        
    //Fecha Otorgada o fecha de Recibida
    [Required(ErrorMessage = "Cual es la fecha de expedicion del prestamo?")]
    public DateTime FechaOtorgada { get; set; }
    
    // //Numero de Cuotas
    // [Required(ErrorMessage = "Cual es el numero de cuotas?")]
    // public int NumeroCuotas { get; set; }
    //
    // // Total a pagar | MontoPrestamo + Interes
    // [Required(ErrorMessage = "Cual es el total a pagar?")]
    // public float TotalPagar { get; set; }
    //
    // //Monto Restante
    // [Required(ErrorMessage = "De cuanto es el monto restante?")]
    // public float MontoRestante { get; set; }
    
}