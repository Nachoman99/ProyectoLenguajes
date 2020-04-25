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
            this.lblMenu.Location = new System.Drawing.Point(332, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(101, 17);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú Principal";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(12, 57);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(298, 17);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Por favor elija una de las siguientes opciones:";
            // 
            // btnMantenimientoClientes
            // 
            this.btnMantenimientoClientes.Location = new System.Drawing.Point(12, 101);
            this.btnMantenimientoClientes.Name = "btnMantenimientoClientes";
            this.btnMantenimientoClientes.Size = new System.Drawing.Size(193, 23);
            this.btnMantenimientoClientes.TabIndex = 2;
            this.btnMantenimientoClientes.Text = "1-Mantenimiento de clientes";
            this.btnMantenimientoClientes.UseVisualStyleBackColor = true;
            this.btnMantenimientoClientes.Click += new System.EventHandler(this.btnMantenimientoClientes_Click);
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(12, 154);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(210, 23);
            this.btnMantenimientoProductos.TabIndex = 3;
            this.btnMantenimientoProductos.Text = "2-Mantenimiento de productos";
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnFacturación
            // 
            this.btnFacturación.Location = new System.Drawing.Point(15, 201);
            this.btnFacturación.Name = "btnFacturación";
            this.btnFacturación.Size = new System.Drawing.Size(103, 23);
            this.btnFacturación.TabIndex = 4;
            this.btnFacturación.Text = "3-Facturación";
            this.btnFacturación.UseVisualStyleBackColor = true;
            this.btnFacturación.Click += new System.EventHandler(this.btnFacturación_Click);
            // 
            // btnReporteFacturacion
            // 
            this.btnReporteFacturacion.Location = new System.Drawing.Point(15, 260);
            this.btnReporteFacturacion.Name = "btnReporteFacturacion";
            this.btnReporteFacturacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReporteFacturacion.Size = new System.Drawing.Size(180, 23);
            this.btnReporteFacturacion.TabIndex = 5;
            this.btnReporteFacturacion.Text = "4-Reporte de facturación";
            this.btnReporteFacturacion.UseVisualStyleBackColor = true;
            this.btnReporteFacturacion.Click += new System.EventHandler(this.btnReporteFacturacion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteFacturacion);
            this.Controls.Add(this.btnFacturación);
            this.Controls.Add(this.btnMantenimientoProductos);
            this.Controls.Add(this.btnMantenimientoClientes);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblMenu);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
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