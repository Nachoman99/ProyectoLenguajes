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

namespace LabInvestigacion.Interfaz
{
    public partial class MenuPrincipal : Form
    {
        Gestor gestor = new Gestor();
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
            this.Visible = false;
            int codigoFactura = gestor.GetLastIdFactura2().CodigoFactura + 1;
            Facturacion facturacion = new Facturacion(codigoFactura, true);
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

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
