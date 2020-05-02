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

        public void eliminarProducto(int codigo)
        {
            gestor.eliminarProducto(codigo);
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
    }
}
