using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtApellidos.Text) || String.IsNullOrEmpty(txtEstadoPaciente.Text)
                || String.IsNullOrEmpty(txtFechaNacimiento.Text) || String.IsNullOrEmpty(txtHistoriaClinica.Text) 
                   || String.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Uno o mas campos estan vacios!!!");
            }
            else if (!Giangiordano.Negocio.Validaciones.EsHistoricaClinicaValida(Int32.Parse(txtHistoriaClinica.Text)))
            {
                MessageBox.Show("El formato de la historia clinica no es valida!!!");
            }
            else
            {
                Giangiordano.Entidades.Paciente paciente = new Giangiordano.Entidades.Paciente();
                try
                {
                    paciente.Apellidos = txtApellidos.Text;
                    paciente.EstadoPaciente = Int32.Parse(txtEstadoPaciente.Text);
                    paciente.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                    paciente.HistoriaClinica = Int32.Parse(txtHistoriaClinica.Text);
                    paciente.Nombres = txtNombres.Text;

                    Giangiordano.Negocio.Paciente.agregar(paciente);

                    MessageBox.Show("El paciente se agrego correctamente");

                }
                catch (Exception exepcion)
                {
                    MessageBox.Show(exepcion.Message);
                }
            }
        }
    }
}
