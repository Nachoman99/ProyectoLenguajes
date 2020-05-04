using AccesoDatos;
using AccesoDatos2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class MetodosInterfaz
    {
        Gestor gestor = new Gestor();



        //Cliente/////////////////////////////////////

        public dynamic consultaCliente()
        {
            return gestor.consultaCliente();
        }

        public void insertarCliente(int cedula, string nombre, string apellido, string correo, string telefono)
        {
            gestor.InsertarCliente(apellido, cedula, correo, nombre, telefono);
        }

        public void actualizarCliente(int cedula, string nombre, string correo, string telefono, string apellido)
        {
            gestor.actualizarCliente(cedula, apellido, correo, nombre, telefono);
        }

        public Boolean verificarCliente(int cedula)
        {
            if (gestor.verCliente(cedula) is null)
            {
                return false;
            }
            return true;
        }

        private Cliente verCliente(int Cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(Cedula);
            return cliente;
        }

        public string verTelefono(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.NumeroTelefono;
        }

        public string verCorreo(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Correo;
        }

        public string verApellido(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Apellido;
        }

        public string verNombreCliente(int cedula)
        {
            Cliente cliente = new Cliente();
            cliente = gestor.verCliente(cedula);
            return cliente.Nombre;
        }

        public Boolean comprobarCorreo(string correo)
        {
            return gestor.comprobarCorreo(correo);
        }

        //Producto/////////////////////////////////////////////////////////////

        public void eliminarProducto(int codigo)
        {
            gestor.eliminarProducto(codigo);
        }

        public dynamic consultaProducto()
        {
            return gestor.consultaProducto();
        }

        public void comprobarExistenciaProducto(String codigo)
        {
            gestor.ComprobarExistenciaProducto(int.Parse(codigo));
        }

        public void eliminarProducto(String codigo)
        {
            gestor.eliminarProducto(int.Parse(codigo));
        }

        public void insertarProducto(String codigo, String desc, String precio, String cantidad)
        {
            gestor.InsertarProducto(int.Parse(codigo), desc, decimal.Parse(precio), int.Parse(cantidad));
        }

        public Producto obtenerProducto(String codigo)
        {
            return gestor.ComprobarExistenciaProducto(int.Parse(codigo));
        }

        public void actualizarProducto(String codigo, String desc, String precio, String cantidad)
        {
            gestor.actualizarProducto(int.Parse(codigo), desc, decimal.Parse(precio), int.Parse(cantidad), false);
        }

        public void eliminarCliente(int cedula)
        {
            gestor.eliminarCliente(cedula);
        }

        public Boolean existeClienteFisico(int cedula)
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

        public Boolean productoExistencteFisico(String codigo)
        {
            Producto producto = gestor.ComprobarExistenciaProducto(int.Parse(codigo));
            if (producto.indicActivoProducto != 0)
            {
                return true;
            }
            return false;
        }

        ///Factura/////////////////////////////////
        ///

        public dynamic reporteFactura(String codigo, DateTime fechaInicio, DateTime fechaFin)
        {
            return gestor.reporteFactura(int.Parse(codigo), fechaInicio, fechaFin);
        }
    }
}
