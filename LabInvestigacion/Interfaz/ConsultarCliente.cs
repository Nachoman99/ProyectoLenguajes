using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using LabInvestigacion.Interfaz;

namespace Interfaz
{
    public partial class ConsultarCliente : Form
    {

        MetodosInterfaz metodos = new MetodosInterfaz();

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = metodos.consultaCliente();
        }

        private void ConsultarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantenimiento = new MantenimientoClientes();
            mantenimiento.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantenimiento = new MantenimientoClientes();
            mantenimiento.Show();
        }
    }
}
