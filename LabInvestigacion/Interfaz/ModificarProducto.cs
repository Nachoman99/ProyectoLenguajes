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

            try
            {
                Producto producto = new Producto();
                if (txbCode.Text != "")
                {
                    if (metodos.productoExistencteFisicoSinError(txbCode.Text))
                    {
                        producto = metodos.obtenerProducto(txbCode.Text);

                        if(producto.Descripcion != null)
                        {
                            txbDesc.Text = producto.Descripcion.ToString();
                            txtbPrice.Text = "" + producto.Precio.ToString();
                            txbQuantity.Text = "" + producto.CantidadInventario.ToString();
                            txbCode.Enabled = false;
                            btCheck.Enabled = false;
                            txbDesc.Enabled = true;
                            txtbPrice.Enabled = true;
                            txbQuantity.Enabled = true;
                            btModify.Enabled = true;
                            label1.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Existe el Producto");
                    }
                }
                else
                {
                    label1.Text = "Debe De Llenar Todas las Casillas";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valores Invalidos");
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCode.Text) || string.IsNullOrEmpty(txbDesc.Text) || string.IsNullOrEmpty(txtbPrice.Text) || string.IsNullOrEmpty(txbQuantity.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }
            try
            {
                if (txbDesc.Text != "" && txtbPrice.Text != "" && txbQuantity.Text != "")
                {
                    metodos.actualizarProducto(txbCode.Text, txbDesc.Text, txtbPrice.Text, txbQuantity.Text);
                    this.Visible = false;
                    MantenimientoProductos mantP = new MantenimientoProductos();
                    mantP.Show();
                }
                else
                {
                    label1.Text = "Debe De Llenar Todas las Casillas";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Valores Invalidos");
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
