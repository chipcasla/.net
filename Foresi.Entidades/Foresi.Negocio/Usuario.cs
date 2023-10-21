namespace Foresi.Negocio
{
    public class Usuario
    {
        public Usuario() { }


        public static List<Entidades.Usuario> findAll()
        {
            return new Datos.Usuario().RecuperarTodos();
        }

        public static void add(Entidades.Usuario usuario)
        {
            new Datos.Usuario().Agregar(usuario);
        }

        public static Entidades.Usuario findOne(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException("El nombre de usuario debe ser completado");
            }

            return new Datos.Usuario().RecuperarUno(nombre);
        }
    }
}