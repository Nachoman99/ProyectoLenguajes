using AccesoDatos;
using AccesoDatos2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        //////////////////////////////////////////////////////////Producto
        ///

        public void eliminarProducto(int codigo)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            var eliminarProducto = from Producto in dc.Producto
                                   where Producto.CodigoProducto == codigo
                                   select Producto;
            
            try
            {
                foreach (var Producto in eliminarProducto)
            {
                dc.Producto.DeleteOnSubmit(Producto);
            }

                dc.SubmitChanges();
                MessageBox.Show("Se eliminó correctamente");
                dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }

        }

        public void actualizarProducto(int codigo, string desc, decimal precio, int cantidad)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Producto producto = dc.Producto.FirstOrDefault(clie => clie.CodigoProducto.Equals(codigo));

            try
            {
                producto.Descripciom = desc;
                producto.Precio = precio;
                producto.CantidadInventario = cantidad;
                dc.SubmitChanges();
                MessageBox.Show("Se actualizó correctamente");
                dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }
            
        }

        public void InsertarProducto(int codigo, string desc, decimal precio, int cantidad)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            try
            {
                Producto producto = new Producto();
                producto.CodigoProducto = codigo;
                producto.Descripciom = desc;
                producto.Precio = precio;
                producto.CantidadInventario = cantidad;
                dc.Producto.InsertOnSubmit(producto);
                dc.SubmitChanges();
                MessageBox.Show("Se insertó exitosamente");
                dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }
        }

        //Consulta Producto

        public Producto ComprobarExistenciaProducto(int codigo)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            Producto producto = new Producto();
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
                producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(codigo));
            }
            catch (Exception)
            {
                throw new Exception("No Existe el Código");
            }
            return producto;
        }

        public Table<Producto> consultaProducto()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            DataTable MyTable = new DataTable();

            return dc.Producto;

            //Aqui se acomoda los datos del cliente--acomodar en la interfaz

            //txtApellido.Text = cliente.Apellido;
            //txtApellido.Text = cliente.Cedula;
            //txtApellido.Text = cliente.Correo;
            //txtApellido.Text = cliente.Nombre;
            //txtApellido.Text = cliente.NumeroTelefono;
            //}
        }

       
    }
}
