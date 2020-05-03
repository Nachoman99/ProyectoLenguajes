using AccesoDatos;
using AccesoDatos2;
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
    public partial class ModificarProducto : Form
    {
        MetodosInterfaz metodos = new MetodosInterfaz();

        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void txbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            Producto producto;

            try
            {
                if (txbCode.Text != "")
                {
                    producto = metodos.obtenerProducto(txbCode.Text);
                    txbDesc.Text = producto.Descripciom.ToString();
                    txbPrice.Text = "" + producto.Precio.ToString();
                    txbQuantity.Text = "" + producto.CantidadInventario.ToString();
                    txbCode.Enabled = false;
                    btCheck.Enabled = false;
                    txbDesc.Enabled = true;
                    txbPrice.Enabled = true;
                    txbQuantity.Enabled = true;
                    btModify.Enabled = true;
                    label1.Text = "";
                } else
                {
                    label1.Text = "Debe De Llenar Todas las Casillas";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbDesc.Text != "" && txbPrice.Text != "" && txbQuantity.Text != "" )
                {
                    metodos.actualizarProducto(txbCode.Text, txbDesc.Text, txbPrice.Text, txbQuantity.Text);
                    this.Visible = false;
                    MantenimientoProductos mantP = new MantenimientoProductos();
                    mantP.Show();
                }
                else
                {
                    label1.Text = "Debe De Llenar Todas las Casillas";
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarProducto_FormClosing(object sender, FormClosingEventArgs e)
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
