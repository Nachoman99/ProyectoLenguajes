using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabInvestigacion.Interfaz;
using LogicaNegocio;

namespace Interfaz
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MetodosInterfaz interfaz = new MetodosInterfaz();
            interfaz.actualizarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtApellido.Text);
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodosInterfaz interfaz = new MetodosInterfaz();
            int cedula = int.Parse(txtCedula.Text);
            if (interfaz.existeClienteFisico(cedula) == true)
            {
                if (interfaz.verificarCliente(cedula) is true)
                {

                    txtCedula.Enabled = false;
                    txtApellido.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtNombre.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtApellido.Text = interfaz.verApellido(cedula);
                    txtCorreo.Text = interfaz.verCorreo(cedula);
                    txtNombre.Text = interfaz.verNombreCliente(cedula);
                    txtTelefono.Text = interfaz.verTelefono(cedula);
                    btnModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El número de cédula no se puede encontrar, por favor digite un número de cédula válido");
                }
            }
            
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }
    }
}
