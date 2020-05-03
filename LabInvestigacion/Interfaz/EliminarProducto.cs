﻿using AccesoDatos;
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

        Gestor gestor = new Gestor();
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
            if (txbCode.Text != "")
            {
                try
                {
                    metodos.comprobarExistenciaProducto(txbCode.Text);
                    metodos.eliminarProducto(txbCode.Text);
                    this.Visible = false;
                    MantenimientoProductos mantP = new MantenimientoProductos();
                    mantP.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }else
            {
                lbError.Text = "Debe de Completar Todos los Espacios";
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MantenimientoProductos mantP = new MantenimientoProductos();
            mantP.Show();
        }
    }
}
