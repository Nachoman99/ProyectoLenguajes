using Interfaz;
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
    public partial class MantenimientoProductos : Form
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        private void MantenimientoProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EliminarProducto ElP = new EliminarProducto();
            ElP.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InsertarProducto insP = new InsertarProducto();
            insP.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultaProducto consP = new ConsultaProducto();
            consP.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModificarProducto modP = new ModificarProducto();
            modP.Show();
        }
    }
}
