using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.Libro.Modelo
{
    public class LibreriaMaterial
    {
        //Cuando se hace la migracion, el Guid lo que hace es buscar las propiedades
        //que termina en Id, y lo crea como clave primaria
        public Guid? LibreriaMaterialId { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Guid? AutorLibro { get; set; }

    }
}
