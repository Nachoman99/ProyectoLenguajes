using AccesoDatos;
using AccesoDatos2;
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
        string cedula;

        public AgregarProductos(int codigoFact, string cedula)
        {
            this.codigoFact = codigoFact;
            this.cedula = cedula;
            InitializeComponent();
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            dgvListProducts.DataSource = gestor.consultaProducto();
        }

        private void btnAgregarProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoProducto = int.Parse(txtProductID.Text);
                gestor.validarProductoAgotado(codigoProducto, int.Parse(txtCantidad.Text));
                Producto producto = gestor.ComprobarExistenciaProducto(codigoProducto);
                int nuevaCantInventario = producto.CantidadInventario - int.Parse(txtCantidad.Text); 
                gestor.actualizarProducto(codigoProducto,producto.Descripciom,producto.Precio, nuevaCantInventario, true);
                gestor.insertarFacturaPorProducto(int.Parse(txtCantidad.Text), int.Parse(txtProductID.Text), codigoFact);
                this.Visible = false;
                Facturacion menu = new Facturacion(codigoFact, false, cedula);
                menu.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Facturacion menu = new Facturacion(codigoFact, false, cedula);
            menu.Visible = true;
        }

        private void dgvListProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
