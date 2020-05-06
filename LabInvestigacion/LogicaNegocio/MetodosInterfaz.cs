using AccesoDatos;
using AccesoDatos2;
using System;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class MetodosInterfaz
    {
        Gestor gestor = new Gestor();

        /// <summary>
        /// Método para consultar los datos de un cliente
        /// </summary>
        /// <returns> El cliente consultado </returns>
        public dynamic ConsultaCliente()
        {
            return gestor.consultaCliente();
        }

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="cedula"> La cedula del cliente a eliminar </param>
        public void EliminarCliente(int cedula)
        {
            gestor.eliminarCliente(cedula);
        }

        /// <summary>
        /// Método para verificar si existe el cliente
        /// </summary>
        /// <param name="cedula"> La cédula del cliente </param>
        /// <returns></returns>
        public Boolean ExisteClienteFisico(int cedula)
        {
            Cliente cliente = gestor.ComprobarExistenciaCliente(cedula);
            if (cliente.indicActivoCliente != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Método para insertar un cliente
        /// </summary>
        /// <param name="cedula"> La cedula del cliente </param>
        /// <param name="nombre"> El nombre del cliente </param>
        /// <param name="apellido"> El apellido del cliente </param>
        /// <param name="correo"> El correo del cliente</param>
        /// <param name="telefono"> El número de teléfono del cliente </param>
        public void InsertarCliente(int cedula, string nombre, string apellido, string correo, string telefono)
        {
            gestor.InsertarCliente(apellido, cedula, correo, nombre, telefono);
        }

        /// <summary>
        /// Método para actualizar los datos de un cliente ya exisatente
        /// </summary>
        /// <param name="cedula"> La cedula del cliente </param>
        /// <param name="nombre"> El nombre del cliente </param>
        /// <param name="correo"> El correo del cliente </param>
        /// <param name="telefono"> El número de teléfono del cliente </param>
        /// <param name="apellido"> El apellido del cliente </param>
        public void ActualizarCliente(int cedula, string nombre, string correo, string telefono, string apellido)
        {
            gestor.actualizarCliente(cedula, apellido, correo, nombre, telefono);
        }

        /// <summary>
        /// Verifica si un cliente existe en la base de datos
        /// </summary>
        /// <param name="cedula"> La cedula del cliente a consultar </param>
        /// <returns> true si el cliente existe, false si el cliente no existe </returns>
        public Boolean VerificarCliente(int cedula)
        {
            if (gestor.verCliente(cedula) is null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método para ver el teléfono de un cliente especifico
        /// </summary>
        /// <param name="cedula"> La cédula del cliente que se quiere consultar </param>
        /// <returns> El teléfono del cliente </returns>
        public string VerTelefono(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.NumeroTelefono;
        }

        /// <summary>
        /// Método para ver el correo de un cliente especifico
        /// </summary>
        /// <param name="cedula"> La cédula del cliente a consultar </param>
        /// <returns> El correo del cliente </returns>
        public string VerCorreo(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Correo;
        }

        /// <summary>
        /// Método para ver el apellido de un cliente específico
        /// </summary>
        /// <param name="cedula"> La cédula del cliente a consultar </param>
        /// <returns> El apellido del cliente </returns>
        public string VerApellido(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Apellido;
        }

        /// <summary>
        /// MMétodo para ver el nombre de un cliente específico
        /// </summary>
        /// <param name="cedula"> La cédula del cliente</param>
        /// <returns> El nombre del cliente </returns>
        public string VerNombreCliente(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Nombre;
        }

        /// <summary>
        /// Método para comprobar el formato correcto del correo
        /// </summary>
        /// <param name="correo"> El correo a verificar </param>
        /// <returns> true si el formato es correcto, false si el formato es incorrecto </returns>
        public Boolean ComprobarCorreo(string correo)
        {
            return gestor.comprobarCorreo(correo);
        }

        /// <summary>
        /// Método para consultar un producto especifico
        /// </summary>
        /// <returns> El producto, null si no lo encuentra </returns>
        public dynamic ConsultaProducto()
        {
            return gestor.consultaProducto();
        }

        /// <summary>
        /// Comprueba si un producto existe en la base o no
        /// </summary>
        /// <param name="codigo"> El codigo del producto a consultar </param>
        public void ComprobarExistenciaProducto(String codigo)
        {
            gestor.ComprobarExistenciaProducto(int.Parse(codigo));
        }

        /// <summary>
        /// Elimina un producto
        /// </summary>
        /// <param name="codigo"> El codigo del producto a eliminar </param>
        public void EliminarProducto(String codigo)
        {
            gestor.eliminarProducto(int.Parse(codigo));
        }

        /// <summary>
        /// Inserta un producto a la base de datos
        /// </summary>
        /// <param name="codigo"> El código del producto </param>
        /// <param name="desc"> La descripción del producto </param>
        /// <param name="precio"> El precio del producto </param>
        /// <param name="cantidad"> La cantidad de productos </param>
        public void InsertarProducto(String codigo, String desc, String precio, String cantidad)
        {
            gestor.InsertarProducto(int.Parse(codigo), desc, decimal.Parse(precio), int.Parse(cantidad));
        }

        /// <summary>
        /// Verifica la existencia de un producto en la base de datos
        /// </summary>
        /// <param name="codigo"> El codigo de la base de datos a consultar </param>
        /// <returns> El producto </returns>
        public Producto ObtenerProducto(String codigo)
        {
            return gestor.ComprobarExistenciaProducto(int.Parse(codigo));
        }

        /// <summary>
        /// Método para modificar un producto
        /// </summary>
        /// <param name="codigo"> El código del producto </param>
        /// <param name="desc"> La descripción del producto </param>
        /// <param name="precio"> El precio del producto </param>
        /// <param name="cantidad"> La cantidad del producto </param>
        public void ActualizarProducto(String codigo, String desc, String precio, String cantidad)
        {
            try
            {
                gestor.actualizarProducto(int.Parse(codigo), desc, decimal.Parse(precio), int.Parse(cantidad), false);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor Invalido");
            }
        }

        /// <summary>
        /// Verifica que el digito enviado es un número
        /// </summary>
        /// <param name="num"> El objeto a verificar </param>
        /// <returns> false si no es un numero o el numero </returns>
        public Boolean EsNumero(object num)
        {
            return gestor.esNumero(num);
        }

        /// <summary>
        /// Verfica si un producto existe en el cliente fisico
        /// </summary>
        /// <param name="codigo"> El código del producto </param>
        /// <returns> true si el producto existe, false de lo contratio </returns>
        public Boolean ProductoExistencteFisico(String codigo)
        {
            try
            {
                Producto producto = gestor.ComprobarExistenciaProducto(int.Parse(codigo));
                if (producto.indicActivoProducto != 0)
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor invalido");
            }
            return false;
        }

        /// <summary>
        /// Verifica si un producto existe
        /// </summary>
        /// <param name="codigo"> El codigo del producto </param>
        /// <returns> true si existe, false si no existe </returns>
        public Boolean ProductoExistencteFisicoSinError(String codigo)
        {
            Producto producto = gestor.ComprobarExistenciaProductoNoError(int.Parse(codigo));
            if (producto.indicActivoProducto != 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para hacer un reporte de factura
        /// </summary>
        /// <param name="codigo"> El codigo de factura </param>
        /// <param name="fechaInicio"> La fecha de inicio de la factura </param>
        ///// <param name="fechaFin"> La fecha fin de la factura </param>
        /// <returns></returns>
        public dynamic reporteFactura(String codigo, DateTime fechaInicio, DateTime fechaFin)
        {
            return gestor.reporteFactura(int.Parse(codigo), fechaInicio, fechaFin);
        }
    }
}
