using System.ComponentModel.DataAnnotations;

namespace ProyectoMVC2.Models
{
    public class PedidosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="La fecha es requerida")]
        public DateTime FechaPedido { get; set; }
        public int IdCliente { get; set; }
        [Required(ErrorMessage ="El estado es requerido")]
        public string Estado { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="El monto total no puede ser negativo")]
        public decimal MontoTotal { get; set; }
        public ClienteModel Cliente { get; set; }
        public ICollection<DetallePedidoModel> DetallePedidos { get; set; }
    }
}
