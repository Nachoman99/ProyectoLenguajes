﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabInvestigacion.Interfaz
{
    public partial class MantenimientoClientes : Form
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
        }

        private void MantenimientoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Visible = true;
            this.Visible = false;
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            InsertarCliente insertar = new InsertarCliente();
            insertar.Visible = true;
        }
    }
}