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
        Boolean sinProductos;
        string cedula;

        public Facturacion(int codigoFactura, Boolean nuevaFactura, Boolean sinProductos)
        {
            this.nuevaFactura = nuevaFactura;
            this.codigoFactura = codigoFactura;
            this.sinProductos = sinProductos;
            InitializeComponent();
        }

        public Facturacion(int codigoFactura, Boolean nuevaFactura, string cedula, Boolean sinProductos)
        {
            this.codigoFactura = codigoFactura;
            this.nuevaFactura = nuevaFactura;
            this.cedula = cedula;
            this.sinProductos = sinProductos;
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
                    this.Visible = false;
                    AgregarProductos addProducts = new AgregarProductos(codigoFactura, cedula,sinProductos);
                    addProducts.Visible = true;
                
                
                }
                else
                {
                this.Visible = false;
                AgregarProductos addProducts = new AgregarProductos(codigoFactura, cedula,sinProductos);
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
            else if (!gestor.esNumero(txtIngreseClientID.Text))
            {
                MessageBox.Show("Verificar que se haya ingresado correctamente la cedula");
            }
            else if (nuevaFactura)
            {
                MessageBox.Show("Verifique que la cedula esta correcta");
            }
            else if (sinProductos)
            {
                MessageBox.Show("Se deben agregar productos a la factura");
            }
            else
            {
                MessageBox.Show("Se ha creado la factura exitosamente");
                this.Visible = false;
                MenuPrincipal menu = new MenuPrincipal();
                menu.Visible = true;
            }
        }

        private void txtIngreseClientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
