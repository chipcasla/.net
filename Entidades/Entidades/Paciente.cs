using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giangiordano.Entidades
{
    public class Paciente
    {
        private string apellidos;
        private int estadoPaciente;
        private DateTime fechaNacimiento;
        private int historiaClinica;
        private string nombres;

        public Paciente(string apellidos, int estadoPaciente, DateTime fechaNacimiento, int historiaClinica, string nombres)
        {
            this.Apellidos = apellidos;
            this.EstadoPaciente = estadoPaciente;
            this.FechaNacimiento = fechaNacimiento;
            this.HistoriaClinica = historiaClinica;
            this.Nombres = nombres;
        }

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int EstadoPaciente { get => estadoPaciente; set => estadoPaciente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int HistoriaClinica { get => historiaClinica; set => historiaClinica = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public int Edad {
            get {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }

        public Paciente()
        {

        }
    }
}
