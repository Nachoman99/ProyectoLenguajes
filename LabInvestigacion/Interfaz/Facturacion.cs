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

        int codigoFactura;
        Boolean nuevaFactura;
        string cedula;

        public Facturacion(int codigoFactura, Boolean nuevaFactura)
        {
            this.nuevaFactura = nuevaFactura;
            this.codigoFactura = codigoFactura; 
            InitializeComponent();
        }

        public Facturacion(int codigoFactura, Boolean nuevaFactura, string cedula)
        {
      
            this.nuevaFactura = nuevaFactura;
            this.codigoFactura = codigoFactura;
            this.cedula = cedula;
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
            txtIngreseClientID.Text = cedula;
            if (!nuevaFactura)
            {
                txtIngreseClientID.Enabled = false;
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtIngreseClientID.Text))
                {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
                }

                if(nuevaFactura)
                {
                
                    cedula = txtIngreseClientID.Text;
                    gestor.ComprobarExistenciaCliente(int.Parse(cedula));
                    gestor.insertarFactura(codigoFactura, int.Parse(cedula));
                    this.Visible = false;
                    AgregarProductos addProducts = new AgregarProductos(codigoFactura, cedula);
                    addProducts.Visible = true;
                
                
                }
                else
                {
                this.Visible = false;
                AgregarProductos addProducts = new AgregarProductos(codigoFactura, cedula);
                addProducts.Visible = true;
                 }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearFact_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIngreseClientID.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }

            MessageBox.Show("Se ha creado la factura exitosamente");
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void txtIngreseClientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
