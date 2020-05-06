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

namespace LabInvestigacion.Interfaz
{
    public partial class ReporteFacturacion : Form
    {
        MetodosInterfaz metodos = new MetodosInterfaz();

        public ReporteFacturacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void ReporteFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }


        private void btVerificar_Click(object sender, EventArgs e)
        {
            try
           {
                if (txbCheck.Text != "")
                {
                    if (metodos.ExisteClienteFisico(int.Parse(txbCheck.Text)))
                    {
                        String dato;
                        dato = metodos.reporteFactura(txbCheck.Text, mCalentarStart.SelectionStart, mCalentarEnd.SelectionStart);

                        //foreach (var factura in facturas)
                        //{
                        //    text += factura + "\r\n" + "\r\n";
                        //}
                        txbFactura.Text = dato;
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no Existe");
                   }
                }
                else
                {
                    lbError.Text = "Debe de Llenar la Casilla";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Usuario no Encontrado");
            }
            
        }

        private void ReporteFacturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
