using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkIngresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(this.txtNombre.Text, this.txtApellido.Text, this.txtMail.Text, this.txtPass.Text);
            if (Ingreso.Program.AddPersona(persona))
            {
                this.lblValidar.Visible = true;
                this.lblValidar.Text = "Registrado con éxito!!!";
                this.lblValidar.ForeColor = Color.Green;

            }
            else
            {
                this.lblValidar.Visible = true;
                this.lblValidar.Text = "Ya está registrado en el sistema. Intente ingresar";
                this.lblValidar.ForeColor = Color.Red;
            }

        }
    }
}
