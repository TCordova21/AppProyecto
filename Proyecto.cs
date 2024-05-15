using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyecto.Entidades
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }   // PK 

        [DisplayName("Nombre del Proyecto")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [DisplayName("Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Fecha de Fin")]
        public DateTime FechaFin { get; set; }

        [DisplayName("Estado del Proyecto")]
        public string Estado { get; set; }

        public List<Tarea>? Tareas { get; set; }
    }
}
