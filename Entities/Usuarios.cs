using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
       
       


        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
            Fecha = DateTime.Now;
            Email = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            
            
        }
    }
}
