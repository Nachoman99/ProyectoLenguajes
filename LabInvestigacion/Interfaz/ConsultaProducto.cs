using LabInvestigacion.Interfaz;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class ConsultaProducto : Form
    {

        MetodosInterfaz metodo = new MetodosInterfaz();

        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
            dtgProduct.DataSource = metodo.consultaProducto();
        }

        private void ConsultaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }
    }
}
