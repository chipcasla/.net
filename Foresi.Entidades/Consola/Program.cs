using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foresi.Entidades;
using Foresi.Negocio;
using Foresi.Datos;

namespace Foresi.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Entidades.Usuario nuevoElemento = new Entidades.Usuario
            {
                Clave = "asd",
                Email = "alegmail.com",
                NombreUsuario = "Nuevo elemento",
                TipoUsuario = 1,
                UltimoIngreso = DateTime.Now
            };

            // Llama al método para agregar el nuevo elemento
            Negocio.Usuario.add(nuevoElemento);
            List<Entidades.Usuario> resultados = Negocio.Usuario.findAll();
            if(resultados.Count > 0)
            {
                Console.WriteLine("Resultados encontrados:");

                // Itera a través de la colección y muestra los datos en la consola
                foreach (var entidad in resultados)
                {
                    Console.WriteLine($"Propiedad1: {entidad.NombreUsuario}, Propiedad2: {entidad.Email}, Propiedad3: {entidad.Clave}");
                }

            }
            else
            {
                Console.WriteLine("No se encontraron resultados.");
            }

            Entidades.Usuario user = Negocio.Usuario.findOne("Nuevo elemento");
            Console.WriteLine(">>> usuario por nombre");
            Console.WriteLine($"Propiedad1: {user.NombreUsuario}, Propiedad2: {user.Email}, Propiedad3: {user.Clave}");


            Console.ReadKey();
        }
    }
}
