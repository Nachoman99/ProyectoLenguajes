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

        public void ConectarBaseDatos(string nameServer, string database, string integratedSecurity)
        {
            SqlConnection connection = new SqlConnection(@"server=" + nameServer + " ; database=" + database + " ; integrated security =" + " " + integratedSecurity);
        }

        public void eliminarCliente(int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
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
            if (verificarCliente(cedula) is true)
            {
                LecturaArchivos lectura = new LecturaArchivos();
                SqlConnection conexion = new SqlConnection(lectura.leerServer());
                DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
                Cliente cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
                cliente.Nombre = nombre;
                cliente.Apellido = apellido;
                cliente.Correo = correo;
                cliente.NumeroTelefono = numeroTelefono;
                dc.SubmitChanges();
                MessageBox.Show("Se actualizó correctamente");
                dc.Connection.Close();
            }
            else
            {
                MessageBox.Show("La cedula especificada no se encuentra");
            }
        }

        public Cliente verCliente(int cedula)
        {
            string cliente;
            if (verificarCliente(cedula) is true)
            {
                LecturaArchivos lectura = new LecturaArchivos();
                SqlConnection conexion = new SqlConnection(lectura.leerServer());
                DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
                Cliente cliente1 = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
                return cliente1;
            }
            else
            {
                return null;
            }
        }

        private Boolean verificarCliente(int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            try
            {
                Cliente cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void InsertarCliente(string apellido, int cedula, string correo, string nombre, string numeroTelefono)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Cedula = cedula;
            cliente.Correo = correo;
            cliente.Nombre = nombre;
            cliente.NumeroTelefono = numeroTelefono;
            cliente.IndicActivoCliente = 1;
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
            Cliente cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
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

        public void actualizarProducto(int codigo, string desc, decimal precio, int cantidad)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Producto producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(codigo));

            try
            {
                producto.Descripciom = desc;
                producto.Precio = precio;
                producto.CantidadInventario += cantidad;
                producto.IndicActivoProducto = 1;
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
            Producto tempProduct = ComprobarExistenciaProducto(codigo);

            try
            {
                if (tempProduct != null)
                {
                    Producto producto = new Producto();
                    producto.CodigoProducto = codigo;
                    producto.Descripciom = desc;
                    producto.Precio = precio;
                    producto.CantidadInventario = cantidad;
                    producto.IndicActivoProducto = 1;
                    dc.Producto.InsertOnSubmit(producto);
                    dc.SubmitChanges();
                    MessageBox.Show("Se insertó exitosamente");
                    dc.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: Este Producto ya Existe");
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error: " + ex.Message);
            }
            return producto;
        }

        public dynamic consultaProducto()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            var productos = from producto in dc.Producto
                            where producto.IndicActivoProducto == 1
                            select producto;

            return productos;
        }

        public void eliminarProducto(int codigo)
        {
           
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Producto producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(codigo));

            try
            {
                producto.IndicActivoProducto = 0;
                dc.SubmitChanges();
                MessageBox.Show("Se elimino correctamente");
                dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }
        }


        public void insertarFacturaPorProducto(int cantidadProducto, int codigoProducto, int codigoFactura)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            FacturaPorProducto factura_x_Producto = new FacturaPorProducto();
            factura_x_Producto.CantidadProducto = cantidadProducto;
            factura_x_Producto.CodigoProducto_Fk = codigoProducto;
            factura_x_Producto.CodigoFactura_Fk = codigoFactura;
            dc.FacturaPorProducto.InsertOnSubmit(factura_x_Producto);
            dc.SubmitChanges();
            MessageBox.Show("Se insertó exitosamente");
            dc.Connection.Close();
        }


        public void insertarFactura(int codigo, int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Factura factura = new Factura();
            factura.CodigoFactura = codigo;
            factura.Cedula_Fk = cedula;
            factura.FechaFactura = GetDateTime();
            dc.Factura.InsertOnSubmit(factura);
            dc.SubmitChanges();
            MessageBox.Show("Se insertó exitosamente");
            dc.Connection.Close();
        }

        public DateTime GetDateTime()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            
            using (DataClasses1DataContext dc = new DataClasses1DataContext(conexion))
            {
                var dQuery = dc.ExecuteQuery<DateTime>("SELECT getdate()");
                return dQuery.AsEnumerable().First();
            }
        }

    }
}
