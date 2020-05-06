using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace LabInvestigacion.Interfaz
{
    public partial class InsertarCliente : Form
    {
        MetodosInterfaz metodos = new MetodosInterfaz();

        public InsertarCliente()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) 
                || String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }
            try
            {
                if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "")
                {
                    if (metodos.comprobarCorreo(txtCorreo.Text))
                    {
                        if (!metodos.existeClienteFisico(int.Parse(txtCedula.Text)))
                        {
                            metodos.actualizarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtApellido.Text);
                            this.Visible = false;
                            MantenimientoClientes mantenimiento = new MantenimientoClientes();
                            mantenimiento.Show();
                        }
                        else
                        {
                            metodos.insertarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text);
                            this.Visible = false;
                            MantenimientoClientes mantenimiento = new MantenimientoClientes();
                            mantenimiento.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe de Introducir un Correo Válido");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de Llenar todas las Casillas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este Cliente ya Existe");
            }
           
        }

        private void InsertarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void InsertarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantC = new MantenimientoClientes();
            mantC.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantC = new MantenimientoClientes();
            mantC.Show();
        }
    }
}
