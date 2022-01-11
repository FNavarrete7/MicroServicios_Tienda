using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicio.Api.CarritoCompra.Modelo
{
    public class CarritoSesionDetalle
    {
        [Key]
        public int CarritoDetalleId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string ProductoSeleccionado { get; set; }
        public int CarritoSesionId { get; set; }
        public CarritoSesion CarritoSesion { get; set; }


    }
}
