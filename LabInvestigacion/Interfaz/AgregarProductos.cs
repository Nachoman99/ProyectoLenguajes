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
    public partial class AgregarProductos : Form
    {


        Gestor gestor = new Gestor();
        int codigoFact;

        public AgregarProductos(int codigoFact)
        {

            this.codigoFact = codigoFact;
            InitializeComponent();
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            dgvListProducts.DataSource = gestor.consultaProducto();
        }

        private void btnAgregarProduct_Click(object sender, EventArgs e)
        {
            gestor.insertarFacturaPorProducto(int.Parse(txtCantidad.Text), int.Parse(txtProductID.Text), codigoFact);
            this.Visible = false;
            Facturacion menu = new Facturacion();
            menu.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Facturacion menu = new Facturacion();
            menu.Visible = true;
        }
    }
}
