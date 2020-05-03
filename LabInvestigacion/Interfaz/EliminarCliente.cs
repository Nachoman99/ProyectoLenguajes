using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabInvestigacion.Interfaz;
using LogicaNegocio;

namespace Interfaz
{
    public partial class EliminarCliente : Form
    {
        MetodosInterfaz metodos = new MetodosInterfaz();

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (metodos.existeClienteFisico(int.Parse(txtCedula.Text)) == false)
            {
                metodos.eliminarCliente(int.Parse(txtCedula.Text));
                MantenimientoClientes mantenimiento = new MantenimientoClientes();
                this.Visible = false;
                mantenimiento.Show();
            }
            else
            {
                MessageBox.Show("El cliente con esa cédula no existe. Intente con otra");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantenimiento = new MantenimientoClientes();
            mantenimiento.Show();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
