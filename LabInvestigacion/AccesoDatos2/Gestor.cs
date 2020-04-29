using AccesoDatos;
using AccesoDatos2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Gestor
    {

        SqlConnection connection = new SqlConnection(@"server= LAPTOP-3D7M2PMI\SQLSERVERDEV2019 ; database=LanguajesLab1 ; integrated security = true");

        public void ConectarBaseDatos(string nameServer, string database, string integratedSecurity)
        {
            SqlConnection connection = new SqlConnection(@"server=" + nameServer + " ; database=" + database + " ; integrated security =" + " " + integratedSecurity);
        }

        public void eliminarCliente(int cedula)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(connection);
            var clienteElminiar = from Cliente in dc.Cliente
                                  where Cliente.Cedula == cedula
                                  select Cliente;
            foreach (var Cliente in clienteElminiar)
            {
                dc.Cliente.DeleteOnSubmit(Cliente);
            }
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }
            MessageBox.Show("Se eliminó correctamente");
            dc.Connection.Close();
        }

        public void actualizarCliente(int cedula, string apellido, string correo, string nombre, string numeroTelefono)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(connection);
            Cliente cliente = dc.Cliente.FirstOrDefault(clie => clie.Cedula.Equals(cedula));
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Correo = correo;
            cliente.NumeroTelefono = numeroTelefono;
            dc.SubmitChanges();
            MessageBox.Show("Se actualizó correctamente");
            dc.Connection.Close();
        }

        public void InsertarCliente(string apellido, int cedula, string correo, string nombre, string numeroTelefono)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(connection);
            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Cedula = cedula;
            cliente.Correo = correo;
            cliente.Nombre = nombre;
            cliente.NumeroTelefono = numeroTelefono;
            dc.Cliente.InsertOnSubmit(cliente);
            dc.SubmitChanges();
            MessageBox.Show("Se insertó exitosamente");
            dc.Connection.Close();
        }

        public string consultaCliente(int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Cliente cliente = dc.Cliente.FirstOrDefault(clie => clie.Cedula.Equals(cedula));
            string cliente1;
            cliente1 = cliente.Cedula.ToString();
            cliente1 += " " + cliente.Nombre;
            cliente1 += " " + cliente.Apellido;
            cliente1 += " " + cliente.Correo;
            cliente1 += " " + cliente.NumeroTelefono;
            return cliente1;

            //Aqui se acomoda los datos del cliente--acomodar en la interfaz

            //txtApellido.Text = cliente.Apellido;
            //txtApellido.Text = cliente.Cedula;
            //txtApellido.Text = cliente.Correo;
            //txtApellido.Text = cliente.Nombre;
            //txtApellido.Text = cliente.NumeroTelefono;

        }
    }
}
