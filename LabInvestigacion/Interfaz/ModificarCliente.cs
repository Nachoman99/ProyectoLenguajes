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
        MetodosInterfaz interfaz = new MetodosInterfaz();

        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) 
                || String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }

            if (txtCedula.Text != "" && txtNombre.Text != "" && txtCorreo.Text != "" && txtApellido.Text != "")
            {
                if (interfaz.comprobarCorreo(txtCorreo.Text))
                {
                    MetodosInterfaz interfaz = new MetodosInterfaz();
                    interfaz.actualizarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtApellido.Text);
                    this.Visible = false;
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Indique un Correo Válido");
                }
            } 
            else
            {
                MessageBox.Show("Debe de Llenar Todas las Casillas");
            }
                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }
            try
            {
                if (txtCedula.Text != "")
                {
                    int cedula = int.Parse(txtCedula.Text);
                    if (interfaz.existeClienteFisico(cedula))
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
                    }else
                    {
                        MessageBox.Show("El número de cédula no se puede encontrar, por favor digite un número de cédula válido");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de Llenar Todas las Casillas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Valor inválido");
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
            MantenimientoClientes mantC = new MantenimientoClientes();
            mantC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantC = new MantenimientoClientes();
            mantC.Show();
        }
    }
}
