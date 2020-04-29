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
using AccesoDatos;
using AccesoDatos2;

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
            Gestor gestor = new Gestor();
            gestor.InsertarCliente(txtApellido.Text, int.Parse(txtCedula.Text), txtCorreo.Text, txtNombre.Text, txtTelefono.Text);

            //SqlConnection connection;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sql;
            //String ConnectionString = leerServer();
            //connection = new SqlConnection(ConnectionString);
            //sql = "INSERT INTO dbo.Cliente (Cedula, Nombre, Apellido, Correo, NumeroTelefono) VALUES (" + int.Parse(txtCedula.Text) + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtCorreo.Text + "', '" + txtTelefono.Text + "')";
            //SqlCommand command;
            //try
            //{
            //    connection.Open();
            //    command = new SqlCommand(sql, connection);
            //    adapter.InsertCommand = new SqlCommand(sql, connection);
            //    adapter.InsertCommand.ExecuteNonQuery();
            //    command.Dispose();
            //    MessageBox.Show("Se insertó el valor exitosamente");
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocurrió un error: " + ex.Message);
            //    throw;
            //}
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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            String puto;
            Gestor gestor = new Gestor();
            puto = gestor.consultaCliente(int.Parse(txtCedula.Text));
            MessageBox.Show("Los valores son: " + puto);
        }
    }
}
