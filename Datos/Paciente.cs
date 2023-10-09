using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giangiordano.Datos
{
    public class Paciente : Base
    {
        public List<Entidades.Paciente> recuperarTodos()
        {
            List<Entidades.Paciente> pacientes = new List<Entidades.Paciente>();
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("select * from pacientes", con);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Entidades.Paciente paciente = new Entidades.Paciente();
                    paciente.Apellidos = (string)dr["Apellidos"];
                    paciente.Nombres = (string)dr["Nombres"];
                    paciente.HistoriaClinica = (int)dr["HistoriaClinica"];
                    paciente.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    paciente.EstadoPaciente = (int)dr["EstadoPaciente"];
                    pacientes.Add(paciente);
                }
                dr.Close();

            } catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar lista de pacientes", ex);
                throw excepcionManejada;
            }
            finally
            {
                con.Close();
            }
            return pacientes;
        }

        public void agregar(Entidades.Paciente paciente)
        {
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("insert into Pacientes values (@HistoriaClinica,@Apellidos,@Nombres,@FechaNacimiento,@EstadoPaciente)", con);
                comando.Parameters.Add("@HistoriaClinica", SqlDbType.Int).Value = paciente.HistoriaClinica;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = paciente.Apellidos;
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = paciente.Nombres;
                comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = paciente.FechaNacimiento;
                comando.Parameters.Add("@EstadoPaciente", SqlDbType.Int).Value = paciente.EstadoPaciente;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al agregar el paciente", ex);
                throw excepcionManejada;
            }
            finally
            {
                con.Close();
            }
        }

        public Entidades.Paciente recuperarUno(int HistClinica)
        {
            Entidades.Paciente paciente = new Entidades.Paciente();
            List<Entidades.Paciente> pacientes = new List<Entidades.Paciente>();
            try
            {
                pacientes = recuperarTodos();
                paciente = pacientes.FirstOrDefault(p => p.HistoriaClinica.Equals(HistClinica));
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al recuperar el paciente con esa hsitoria clinica", ex);
                throw excepcionManejada;
            }
            return paciente;
        }
    }
}
