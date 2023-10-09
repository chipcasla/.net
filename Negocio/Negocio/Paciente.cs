using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giangiordano.Negocio
{
    public class Paciente
    {
        public static List<Entidades.Paciente> recuperarTodos()
        {
            Datos.Paciente pacienteDato = new Datos.Paciente();
            return pacienteDato.recuperarTodos();
        }

        public static void agregar(Entidades.Paciente paciente)
        {
            Datos.Paciente pacienteDato = new Datos.Paciente();
            pacienteDato.agregar(paciente);
        }
        public static Entidades.Paciente recuperarUno(int HistClinica)
        {
            if (String.IsNullOrEmpty(HistClinica.ToString()))
            {
                throw new Exception("El numero de historia clinica es nulo!");
            }
            Datos.Paciente pacienteDato = new Datos.Paciente();
            return pacienteDato.recuperarUno(HistClinica);
        }
    }
}
