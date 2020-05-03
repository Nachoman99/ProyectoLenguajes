using AccesoDatos;
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
    public partial class Facturacion : Form
    {
        Gestor gestor = new Gestor();
        int codigoFact = 15;
        public Facturacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
            this.Visible = false;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            ++codigoFact;
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AgregarProductos addProducts = new AgregarProductos(codigoFact);
            addProducts.Visible = true;
        }

        private void btnCrearFact_Click(object sender, EventArgs e)
        {
            gestor.insertarFactura(codigoFact, int.Parse(txtIngreseClientID.Text));
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }



    }
}
