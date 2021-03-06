﻿using AccesoDatos;
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
        Boolean isPrimerProducto;

        public AgregarProductos(int codigoFact, string cedula, Boolean isPrimerProducto)
        {
            this.codigoFact = codigoFact;
            this.cedula = cedula;
            this.isPrimerProducto = isPrimerProducto;
            InitializeComponent();
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            dgvListProducts.DataSource = gestor.consultaProducto();
        }

        private void btnAgregarProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductID.Text) || String.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Verificar que no exista un espacio en blanco");
                return;
            }

            try
            {

                int codigoProducto = int.Parse(txtProductID.Text);
                gestor.validarProductoAgotado(codigoProducto, int.Parse(txtCantidad.Text));
                Producto producto = gestor.ComprobarExistenciaProducto(codigoProducto);
                if (isPrimerProducto)
                {
                    gestor.insertarFactura(codigoFact, int.Parse(cedula));
                    isPrimerProducto = false;
                }
                int nuevaCantInventario = producto.CantidadInventario - int.Parse(txtCantidad.Text);
                gestor.actualizarProducto(codigoProducto, producto.Descripcion, producto.Precio, nuevaCantInventario, true);
                gestor.insertarFacturaPorProducto(int.Parse(txtCantidad.Text), int.Parse(txtProductID.Text), codigoFact);
                txtCantidad.Text = "";
                txtProductID.Text = "";
                dgvListProducts.DataSource = gestor.consultaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Facturacion menu = new Facturacion(codigoFact, false, cedula, isPrimerProducto);
            menu.Visible = true;
        }

        private void dgvListProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
