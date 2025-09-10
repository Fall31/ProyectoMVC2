using System.ComponentModel.DataAnnotations;
namespace ProyectoMVC2.Models
{
    public class DetallePedidoModel
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        [Range(0,int.MaxValue, ErrorMessage ="La cantidad no puede ser negativa")]
        public int Cantidad { get; set; }
        [Range(0.1, int.MaxValue, ErrorMessage ="El precio unitario debe ser mayor a cero")]
        public decimal PrecioUnitario { get; set; }
        public PedidosModel Pedido { get; set; }
        public ProductModel Producto { get; set; }
    }
}
