using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicio.Api.CarritoCompra.Modelo
{
    public class CarritoSesion
    {
        [Key]
        public int CarritoSesionId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public ICollection<CarritoSesionDetalle> ListaDetalle { get; set; }

    }
}
