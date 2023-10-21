using Foresi.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foresi.Datos
{
    public class Usuario
    {
        private Base conexion;

        public Usuario()
        {
            conexion = new Base();
        }

        public List<Entidades.Usuario> RecuperarTodos()
        {
            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();
            using (SqlCommand cmd = new SqlCommand("select * from Usuarios", conexion.Conexion))
            {
                conexion.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Entidades.Usuario user = new Entidades.Usuario
                        {
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Clave = reader["Clave"].ToString(),
                            TipoUsuario = int.Parse(reader["TipoUsuario"].ToString()),
                            Email = reader["Email"].ToString(),
                            UltimoIngreso = Convert.ToDateTime(reader["UltimoIngreso"])
                        };
                        usuarios.Add(user);
                    }
                }
                conexion.closeConnection();
            }
            return usuarios;
        }

        public void Agregar(Entidades.Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("insert into Usuarios " +
                "(NombreUsuario, Clave, TipoUsuario, Email, UltimoIngreso) " +
                "values (@nombreUsuario, @clave, @tipoUsuario, @email, @ultIngreso)"
                , conexion.Conexion))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@clave", u.Clave);
                cmd.Parameters.AddWithValue("@tipoUsuario", u.TipoUsuario);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@ultIngreso", u.UltimoIngreso);

                conexion.openConnection();
                cmd.ExecuteNonQuery();
                conexion.closeConnection();
            }
                 
        }

        public Entidades.Usuario RecuperarUno(string nombreUsuario)
        {
            List<Entidades.Usuario> usuarios = RecuperarTodos();
            Entidades.Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            return usuarioEncontrado;
        }
    }
}
