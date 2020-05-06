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
    public partial class EliminarProducto : Form
    {

        MetodosInterfaz metodos = new MetodosInterfaz();

        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbCode.Text))
                {
                    MessageBox.Show("Verificar que no exista un espacio en blanco");
                    return;
                }

                if (txbCode.Text != "")
                {

                        if (metodos.ProductoExistencteFisicoSinError(txbCode.Text))
                        {
                            //metodos.comprobarExistenciaProducto(txbCode.Text);
                            metodos.EliminarProducto(txbCode.Text);
                            this.Visible = false;
                            MantenimientoProductos mantP = new MantenimientoProductos();
                            mantP.Show();
                        }
                        else
                        {
                            MessageBox.Show("El Producto no Existe");
                        }
                }
                else
                {
                    lbError.Text = "Debe de Completar Todos los Espacios";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores Invalidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto no Existe");
            }   
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
