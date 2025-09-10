﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoMVC2.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="E; email es obligatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage ="La direccion es obligatoria")]
        public string Direccion {  get; set; }
        public ICollection<PedidosModel> Pedidos { get; set; }
    }
}
