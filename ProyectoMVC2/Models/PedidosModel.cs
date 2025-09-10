namespace ProyectoMVC2.Models
{
    public class PedidosModel
    {
        public int Id { get; set; }
        public DateTime echaPedido { get; set; }
        public int IdCliente { get; set; }
        public string Estado { get; set; }
        public decimal MontoTotal { get; set; }
        public ClienteModel Cliente { get; set; }
        public ICollection<DetallePedidoModel> DetallePedidos { get; set; }
    }
}
