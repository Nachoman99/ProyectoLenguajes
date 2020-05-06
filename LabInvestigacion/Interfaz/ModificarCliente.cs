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

            MetodosInterfaz metodos = new MetodosInterfaz();
            try
            {
                if (metodos.EsNumero(txtCedula.Text) != false)
                {
                    metodos.ActualizarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtApellido.Text);
                    this.Visible = false;
                    MantenimientoClientes mantC = new MantenimientoClientes();
                    mantC.Show();
                }
                else
                {
                    throw new Exception("Error: Cédula no válida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    if (interfaz.ExisteClienteFisico(cedula))
                    {
                        if (interfaz.VerificarCliente(cedula) is true)
                        {
                            txtCedula.Enabled = false;
                            txtApellido.Enabled = true;
                            txtCorreo.Enabled = true;
                            txtNombre.Enabled = true;
                            txtTelefono.Enabled = true;
                            txtApellido.Text = interfaz.VerApellido(cedula);
                            txtCorreo.Text = interfaz.VerCorreo(cedula);
                            txtNombre.Text = interfaz.VerNombreCliente(cedula);
                            txtTelefono.Text = interfaz.VerTelefono(cedula);
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
