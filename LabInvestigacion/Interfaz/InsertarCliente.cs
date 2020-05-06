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

            MetodosInterfaz metodos = new MetodosInterfaz();
            try
            {
                if (metodos.esNumero(txtCedula.Text))
                {
                    metodos.insertarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text);
                    this.Visible = false;
                    MantenimientoClientes mantC = new MantenimientoClientes();
                    mantC.Show();
                }
                else
                {
                    throw new Exception("Digite la cédula correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
