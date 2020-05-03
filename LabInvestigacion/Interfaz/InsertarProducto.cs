using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LabInvestigacion.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using LogicaNegocio;

namespace Interfaz
{
    public partial class InsertarProducto : Form
    {
        MetodosInterfaz metodos = new MetodosInterfaz();

        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void InsertarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txbCode.Text != "" & txbDesc.Text != "" & txbPrice.Text != "" & txbQuantity.Text != "")
            {
                try
                {
                    metodos.insertarProducto(txbCode.Text, txbDesc.Text, txbPrice.Text, txbQuantity.Text);
                    this.Visible = false;
                    MantenimientoProductos mantP = new MantenimientoProductos();
                    mantP.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                label1.Text = "Debe de Llenar Todos los Espacios";
            }
        }

        private void InsertarProducto_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }
    }
}
