using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class frmRecuperar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btmRecuperar_Click(object sender, EventArgs e)
        {
            Giangiordano.Entidades.Paciente paciente = new Giangiordano.Entidades.Paciente();
            try
            {
                paciente = Giangiordano.Negocio.Paciente.recuperarUno(Int32.Parse(txtHistoriaClinica.Text));

                if (paciente == null)
                {
                    Response.Write("No existe paciente con ese numero de historia clinica");
                }
                else
                {
                    lblApelldos.Text = paciente.Apellidos;
                    lblEstadoPaciente.Text = paciente.EstadoPaciente.ToString();
                    lblFechaNacimiento.Text = paciente.FechaNacimiento.ToString();
                    lblHistoriaClinica.Text = paciente.HistoriaClinica.ToString();
                    lblNombres.Text = paciente.Nombres;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}