using AccesoDatos;
using LabInvestigacion.Interfaz;
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

        Gestor gestor = new Gestor();

        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
            dtgProduct.DataSource = gestor.consultaProducto();
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
