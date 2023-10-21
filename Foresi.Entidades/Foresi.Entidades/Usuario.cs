using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foresi.Entidades
{
    public class Usuario
    {
        private readonly object get;

        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime UltimoIngreso { get; set; }

        public Usuario() { }

        public Usuario(string clave, string email, string nombreUsuario, int tipoUsuario, DateTime ultimoIngreso)
        {
            Clave = clave;
            Email = email;
            NombreUsuario = nombreUsuario;
            TipoUsuario = tipoUsuario;
            UltimoIngreso = ultimoIngreso;
        }

        public int DiasUltimoIngreso()
        {
            int tiempoTranscurrido = (DateTime.Now - this.UltimoIngreso).Days;

            return tiempoTranscurrido;
        }
    }
}
