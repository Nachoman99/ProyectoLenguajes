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
        public InsertarCliente()
        {
            InitializeComponent();
        }

        private void InsertarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MetodosInterfaz metodos = new MetodosInterfaz();
            metodos.insertarCliente(int.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text);
        }

        public string leerServer()
        {
            string fichero = (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rutaCoca.txt"));
            string server = "";
            StreamReader reader = new StreamReader(fichero);
            string[] line;

            if (File.Exists(fichero))
            {
                server = reader.ReadToEnd();
            }
            return server;
        }
    }
}
