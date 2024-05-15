using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppProyecto.Entidades
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }   // PK 

        [DisplayName("Descripción de la Tarea")]
        public string Descripcion { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Fecha de Vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        [DisplayName("Estado de la Tarea")]
        public string Estado { get; set; }

        public int ProyectoId { get; set; }   // FK 

        public Proyecto? Proyecto { get; set; }   // Relación de navegación
    }
}
