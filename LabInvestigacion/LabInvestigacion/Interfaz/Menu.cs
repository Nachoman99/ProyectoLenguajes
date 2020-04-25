using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabInvestigacion.Interfaz
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMantenimientoClientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoClientes mantenimientoClientes = new MantenimientoClientes();
            mantenimientoClientes.Visible = true;
        }

        private void btnMantenimientoProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantenimientoProductos = new MantenimientoProductos();
            mantenimientoProductos.Visible = true;
        }

        private void btnFacturación_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Facturacion facturacion = new Facturacion();
            facturacion.Visible = true;
        }

        private void btnReporteFacturacion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReporteFacturacion reporte = new ReporteFacturacion();
            reporte.Visible = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
