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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace AccesoDatos
{
    public class Gestor
    {

        private string reporteFinal = "";

        public void ConectarBaseDatos(string nameServer, string database, string integratedSecurity)
        {
            SqlConnection connection = new SqlConnection(@"server=" + nameServer + " ; database=" + database + " ; integrated security =" + " " + integratedSecurity);
        }

        public dynamic consultaCliente()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            var clientes = from cliente in dc.Cliente
                           where cliente.indicActivoCliente == 1
                           select cliente;
            return clientes;
        }

        public void actualizarCliente(int cedula, string apellido, string correo, string nombre, string numeroTelefono)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            try
            {
                if (cedula > 0 && esNumero(cedula) != false)
                {

                    Cliente cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
                    if (nombre != null && nombre != "")
                    {
                        cliente.Nombre = nombre;
                    }
                    else
                    {
                        throw new Exception("Error: El nombre no es válido.");
                    }
                    if (apellido != null && apellido != "")
                    {
                        cliente.Apellido = apellido;
                    }
                    else
                    {
                        throw new Exception("Error: El apellido no es válido.");
                    }
                    if (comprobarCorreo(correo) == true)
                    {
                        cliente.Correo = correo;
                    }
                    else
                    {
                        throw new Exception("Error: Correo no válido.");
                    }
                    if (esNumero(numeroTelefono) != false)
                    {
                        cliente.NumeroTelefono = numeroTelefono;
                    }
                    else
                    {
                        throw new Exception("Error: Número de teléfono no válido.");
                    }
                    cliente.indicActivoCliente = 1;
                    dc.SubmitChanges();
                    MessageBox.Show("Se actualizó correctamente");
                    dc.Connection.Close();
                }
                else
                {
                    throw new Exception("Error: La cedula no es válida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: " + ex.Message);
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
            try
            {
                LecturaArchivos lectura = new LecturaArchivos();
                SqlConnection conexion = new SqlConnection(lectura.leerServer());
                DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
                Cliente cliente = new Cliente();
                if (apellido != null && apellido != "")
                {
                    cliente.Apellido = apellido;
                }
                else
                {
                    throw new Exception("El apellido no puede estar vacío");
                }
                if (cedula > 0 && esNumero(cedula) != false)
                {
                    cliente.Cedula = cedula;
                }
                else
                {
                    throw new Exception("Digite una cédula válida");
                }
                if (comprobarCorreo(correo) == true)
                {
                    cliente.Correo = correo;
                }
                else
                {
                    throw new Exception("Digite un correo válido");
                }
                if (nombre != null && nombre != "")
                {
                    cliente.Nombre = nombre;
                }
                else
                {
                    throw new Exception("Digite un nombre válido");
                }
                if (numeroTelefono != null && numeroTelefono != "" && esNumero(numeroTelefono) != false)
                {
                    cliente.NumeroTelefono = numeroTelefono;
                }
                else
                {
                    throw new Exception("Digite un número de teléfono válido");
                }


                Cliente cliente1 = ComprobarExistenciaCliente(cedula);
                if (cliente1.indicActivoCliente == null)
                {
                    cliente.indicActivoCliente = 1;
                    dc.Cliente.InsertOnSubmit(cliente);
                    dc.SubmitChanges();
                    MessageBox.Show("Se insertó exitosamente");
                    dc.Connection.Close();
                }else if(cliente1.indicActivoCliente == 1)
                {
                    throw new Exception("Este cliente ya existe, no se puede insertar.");
                }
                else if(cliente1.indicActivoCliente == 0)
                {
                    cliente.indicActivoCliente = 1;
                    dc.SubmitChanges();
                    MessageBox.Show("Se insertó exitosamente");
                    dc.Connection.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrió un error, verifique la ruta de acceso a la base de datos.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Este Cliente ya Existe");
            }
        }

        public Boolean comprobarCorreo(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public Boolean esNumero(object objeto)
        {
            Boolean esNumero;
            int retNumero;
            esNumero = int.TryParse(Convert.ToString(objeto), out retNumero);
            return esNumero;
        }

        //////////////////////////////////////////////////////////Producto
        ///

        public void actualizarProducto(int codigo, string desc, decimal precio, int cantidad, Boolean isAddProduct)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Producto producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(codigo));

            try
            {
                if (cantidad == 0)
                {
                    producto.indicActivoProducto = 0;
                }
                else
                {
                    producto.indicActivoProducto = 1;

                }

                if (isAddProduct)
                {
                    producto.Descripciom = desc;
                    producto.Precio = precio;
                    producto.CantidadInventario = cantidad;
                    dc.SubmitChanges();
                    dc.Connection.Close();
                }
                else
                {
                    producto.Descripciom = desc;
                    producto.Precio = precio;
                    producto.CantidadInventario = cantidad;
                    dc.SubmitChanges();
                    MessageBox.Show("Se actualizó correctamente");
                    dc.Connection.Close();
                }
               
            
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
            Producto tempProduct = ComprobarExistenciaProductoNoError(codigo);

            try
            {
                if (tempProduct != null)
                {
                    Producto producto = new Producto();
                    producto.CodigoProducto = codigo;
                    producto.Descripciom = desc;
                    producto.Precio = precio;
                    producto.CantidadInventario = cantidad;
                    producto.indicActivoProducto = 1;
                    dc.Producto.InsertOnSubmit(producto);
                    dc.SubmitChanges();
                    MessageBox.Show("Se insertó exitosamente");
                    dc.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este Producto ya Existe");
                dc.Connection.Close();
            }
        }

        public Cliente ComprobarExistenciaCliente(int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            Cliente cliente = new Cliente();

            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
                cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocurrió un error: Cliente no Existe");
            }
            return cliente;
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
                MessageBox.Show("Producto no existe");
            }
            return producto;
        }

        public Producto ComprobarExistenciaProductoNoError(int codigo)
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
                //MessageBox.Show("Producto no existe");
            }
            return producto;
        }

        public dynamic consultaProducto()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            var productos = from producto in dc.Producto
                            where producto.indicActivoProducto == 1
                            select producto;

            return productos;
        }

        public void eliminarCliente(int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Cliente cliente = dc.Cliente.First(clie => clie.Cedula.Equals(cedula));
            try
            {
                cliente.indicActivoCliente = 0;
                dc.SubmitChanges();
                MessageBox.Show("El cliente se eliminó correctamente");
                dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                dc.Connection.Close();
            }
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
                    producto.indicActivoProducto = 0;
                    dc.SubmitChanges();
                    MessageBox.Show("Se elimino correctamente");
                    dc.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto no Existe");
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
            MessageBox.Show("Se ha agregado el producto exitosamente");
            dc.Connection.Close();
        }

        public void insertarFactura(int codigoFactura, int cedula)
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            Factura factura = new Factura();
            factura.CodigoFactura = codigoFactura;
            factura.Cedula_Fk = cedula;
            factura.FechaFactura = GetDateTime();
            dc.Factura.InsertOnSubmit(factura);
            dc.SubmitChanges();
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

        public Factura GetLastIdFactura()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            using (DataClasses1DataContext dc = new DataClasses1DataContext(conexion))
            {
                var dQuery = dc.ExecuteQuery<Factura>("SELECT TOP 1 CodigoFactura FROM dbo.Factura ORDER BY Factura.CodigoFactura DESC");
                return dQuery.AsEnumerable().First();
            }
        }

        //public dynamic reporteFactura(int clienteID, DateTime fechaInicio, DateTime fechaFin)
        //{
        //    LecturaArchivos lectura = new LecturaArchivos();
        //    SqlConnection conexion = new SqlConnection(lectura.leerServer());

        //    DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

        //    var facturas = from factura in dc.Factura
        //                   where factura.Cedula_Fk == clienteID
        //                   where factura.FechaFactura >= fechaInicio
        //                   where factura.FechaFactura <= fechaFin
        //                   select factura;
        //    return facturas;
        //}


        public List<int> codigosFacturas(int clienteID, DateTime fechaInicio, DateTime fechaFin)
        {
            List<int> codigoFactura = new List<int>();
            reporteFinal = "";

            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            var facturas = from factura in dc.Factura
                           where factura.Cedula_Fk == clienteID
                           where factura.FechaFactura >= fechaInicio
                           where factura.FechaFactura <= fechaFin
                           select factura;

            foreach (var factura in facturas)
            {
                codigoFactura.Add(factura.CodigoFactura);
                reporteFinal += "Factura ID: " + factura.CodigoFactura + "\r\n" +
                    "Fecha De La Factura: " + factura.FechaFactura.ToString() + "\r\n";
            }

            return codigoFactura;
        }

        public string reporteFactura(int clienteID, DateTime fechaInicio, DateTime fechaFin)
        {

            int dato;
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            List<int> codigoFacturas = codigosFacturas(clienteID, fechaInicio, fechaFin);
            List<FacturaPorProducto> intermedios = new List<FacturaPorProducto>();
            List<Producto> productos = new List<Producto>();
            foreach (var codigo in codigoFacturas)
            {

                FacturaPorProducto fpp = dc.FacturaPorProducto.First(clie => clie.CodigoFactura_Fk.Equals(codigo));
                dato = fpp.CodigoProducto_Fk;
                intermedios.Add(fpp);
            }

            int cantidad = 0;
            decimal precio = 0;
            decimal total = 0;
            foreach (var intermedio in intermedios)
            {
                Producto producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(intermedio.CodigoProducto_Fk));
                productos.Add(producto);
                cantidad = intermedio.CantidadProducto;
                precio = producto.Precio;
                total += (cantidad * precio);
            }
            reporteFinal += "Total Facturado: " + total;

            return reporteFinal;
        }

        public dynamic GetLastIdFactura2()
        {
            LecturaArchivos lectura = new LecturaArchivos();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());

            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);

            var fact = from factura in dc.Factura
                       orderby factura.CodigoFactura descending
                       select factura;

            return fact.First();
        }



        public void validarProductoAgotado(int codigoProducto, int cantidadSolicitada)
        {
                        
                Producto product = GetProducto(codigoProducto);
                if (product.CantidadInventario == 0)
                { 
                    throw new Exception("El producto " + product.Descripciom + " se encuentra agotado");
                }
                else if(product.CantidadInventario < cantidadSolicitada)
                {
                    throw new Exception("La cantidad solicitada excede la cantidad en inventario del producto" + product.Descripciom);
                }
                
            
        }

        public Producto GetProducto(int codigo)
        {

            LecturaArchivos lectura = new LecturaArchivos();
            DataTable MiDataTable = new DataTable();
            SqlConnection conexion = new SqlConnection(lectura.leerServer());
            Producto producto = new Producto();    
            DataClasses1DataContext dc = new DataClasses1DataContext(conexion);
            producto = dc.Producto.First(clie => clie.CodigoProducto.Equals(codigo));
      
            return producto;
        }

    }
}
