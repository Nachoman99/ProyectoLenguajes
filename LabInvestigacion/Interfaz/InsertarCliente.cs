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
            if (txtCorreo.Text.Contains("@"))
            {
                metodos.insertarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text);
            }
            else
            {
                MessageBox.Show("Debe de Introducir un Correo Válido");
            }
        }
    }
}
