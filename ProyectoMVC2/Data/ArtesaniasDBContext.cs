using Microsoft.EntityFrameworkCore;
using ProyectoMVC2.Models;

namespace ProyectoMVC2.Data
{
    public class ArtesaniasDBContext : DbContext
    {
        public ArtesaniasDBContext(DbContextOptions<ArtesaniasDBContext> options) : base(options) { }

        public DbSet<ProductModel> Productos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<PedidosModel> Pedidos { get; set; }
        public DbSet<DetallePedidoModel> DetallePedidos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación entre Pedido y Cliente (Many-to-One)
            // Un Pedido tiene Un Cliente, y Un Cliente tiene Muchos Pedidos
            modelBuilder.Entity<PedidosModel>()
                .HasOne(p => p.Cliente) // Un Pedido tiene un Cliente
                .WithMany(c => c.Pedidos) // Un Cliente tiene muchos Pedidos
                .HasForeignKey(p => p.IdCliente); // La clave foránea es IdCliente

            // Configuración de la relación entre Pedido y DetallePedido (One-to-Many)
            // Un Pedido tiene Muchos Detalles de Pedido
            modelBuilder.Entity<PedidosModel>()
                .HasMany(p => p.DetallePedidos) // Un Pedido tiene muchos DetallePedidos
                .WithOne(d => d.Pedido) // Un DetallePedido pertenece a un Pedido
                .HasForeignKey(d => d.IdPedido); // La clave foránea es IdPedido

            // Configuración de la relación entre DetallePedido y Producto (Many-to-One)
            // Un DetallePedido tiene Un Producto, y Un Producto tiene Muchos Detalles de Pedido
            modelBuilder.Entity<DetallePedidoModel>()
                .HasOne(d => d.Producto) // Un DetallePedido tiene un Producto
                .WithMany(p => p.DetallePedido) // Un Producto tiene muchos DetallePedidos
                .HasForeignKey(d => d.IdProducto); // La clave foránea es IdProducto
        }
    }

}