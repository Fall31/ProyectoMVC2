using System.ComponentModel.DataAnnotations;
namespace ProyectoMVC2.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [StringLength(500)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="El precio es obligatorio.")]
        [Range(0.01, double.MaxValue,ErrorMessage ="El precio debe ser mayor a cero.")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage ="El stock es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage ="El stock no puede ser negativo.")]
        public int Stock {  get; set; }
        public ICollection<DetallePedidoModel> DetallePedido { get; set; }
     
    }
}
