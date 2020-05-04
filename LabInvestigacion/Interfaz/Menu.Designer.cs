namespace LabInvestigacion.Interfaz
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnMantenimientoClientes = new System.Windows.Forms.Button();
            this.btnMantenimientoProductos = new System.Windows.Forms.Button();
            this.btnFacturación = new System.Windows.Forms.Button();
            this.btnReporteFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(249, 7);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(77, 13);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú Principal";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(9, 37);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(222, 13);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Por favor elija una de las siguientes opciones:";
            // 
            // btnMantenimientoClientes
            // 
            this.btnMantenimientoClientes.AutoSize = true;
            this.btnMantenimientoClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimientoClientes.Location = new System.Drawing.Point(9, 82);
            this.btnMantenimientoClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMantenimientoClientes.Name = "btnMantenimientoClientes";
            this.btnMantenimientoClientes.Size = new System.Drawing.Size(149, 23);
            this.btnMantenimientoClientes.TabIndex = 2;
            this.btnMantenimientoClientes.Text = "1-Mantenimiento de clientes";
            this.btnMantenimientoClientes.UseVisualStyleBackColor = true;
            this.btnMantenimientoClientes.Click += new System.EventHandler(this.btnMantenimientoClientes_Click);
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.AutoSize = true;
            this.btnMantenimientoProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(9, 125);
            this.btnMantenimientoProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(160, 23);
            this.btnMantenimientoProductos.TabIndex = 3;
            this.btnMantenimientoProductos.Text = "2-Mantenimiento de productos";
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnFacturación
            // 
            this.btnFacturación.AutoSize = true;
            this.btnFacturación.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturación.Location = new System.Drawing.Point(11, 163);
            this.btnFacturación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturación.Name = "btnFacturación";
            this.btnFacturación.Size = new System.Drawing.Size(82, 23);
            this.btnFacturación.TabIndex = 4;
            this.btnFacturación.Text = "3-Facturación";
            this.btnFacturación.UseVisualStyleBackColor = true;
            this.btnFacturación.Click += new System.EventHandler(this.btnFacturación_Click);
            // 
            // btnReporteFacturacion
            // 
            this.btnReporteFacturacion.AutoSize = true;
            this.btnReporteFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteFacturacion.Location = new System.Drawing.Point(11, 211);
            this.btnReporteFacturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporteFacturacion.Name = "btnReporteFacturacion";
            this.btnReporteFacturacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReporteFacturacion.Size = new System.Drawing.Size(135, 23);
            this.btnReporteFacturacion.TabIndex = 5;
            this.btnReporteFacturacion.Text = "4-Reporte de facturación";
            this.btnReporteFacturacion.UseVisualStyleBackColor = true;
            this.btnReporteFacturacion.Click += new System.EventHandler(this.btnReporteFacturacion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnReporteFacturacion);
            this.Controls.Add(this.btnFacturación);
            this.Controls.Add(this.btnMantenimientoProductos);
            this.Controls.Add(this.btnMantenimientoClientes);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnMantenimientoClientes;
        private System.Windows.Forms.Button btnMantenimientoProductos;
        private System.Windows.Forms.Button btnFacturación;
        private System.Windows.Forms.Button btnReporteFacturacion;
    }
}