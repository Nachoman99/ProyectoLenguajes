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
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnMantenimientoClientes = new System.Windows.Forms.Button();
            this.btnMantenimientoProductos = new System.Windows.Forms.Button();
            this.btnFacturación = new System.Windows.Forms.Button();
            this.btnReporteFacturacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(38, 46);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(299, 15);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Por favor elija una de las siguientes opciones";
            // 
            // btnMantenimientoClientes
            // 
            this.btnMantenimientoClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimientoClientes.Location = new System.Drawing.Point(14, 80);
            this.btnMantenimientoClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenimientoClientes.Name = "btnMantenimientoClientes";
            this.btnMantenimientoClientes.Size = new System.Drawing.Size(149, 41);
            this.btnMantenimientoClientes.TabIndex = 2;
            this.btnMantenimientoClientes.Text = "1 - Mantenimiento de clientes";
            this.btnMantenimientoClientes.UseVisualStyleBackColor = true;
            this.btnMantenimientoClientes.Click += new System.EventHandler(this.btnMantenimientoClientes_Click);
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(14, 135);
            this.btnMantenimientoProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(149, 41);
            this.btnMantenimientoProductos.TabIndex = 3;
            this.btnMantenimientoProductos.Text = "2 - Mantenimiento de productos";
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnFacturación
            // 
            this.btnFacturación.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturación.Location = new System.Drawing.Point(206, 80);
            this.btnFacturación.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturación.Name = "btnFacturación";
            this.btnFacturación.Size = new System.Drawing.Size(149, 41);
            this.btnFacturación.TabIndex = 4;
            this.btnFacturación.Text = "3 - Facturación";
            this.btnFacturación.UseVisualStyleBackColor = true;
            this.btnFacturación.Click += new System.EventHandler(this.btnFacturación_Click);
            // 
            // btnReporteFacturacion
            // 
            this.btnReporteFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteFacturacion.Location = new System.Drawing.Point(206, 135);
            this.btnReporteFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteFacturacion.Name = "btnReporteFacturacion";
            this.btnReporteFacturacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReporteFacturacion.Size = new System.Drawing.Size(149, 41);
            this.btnReporteFacturacion.TabIndex = 5;
            this.btnReporteFacturacion.Text = "4 - Reporte de facturación";
            this.btnReporteFacturacion.UseVisualStyleBackColor = true;
            this.btnReporteFacturacion.Click += new System.EventHandler(this.btnReporteFacturacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Menú Principal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(375, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReporteFacturacion);
            this.Controls.Add(this.btnFacturación);
            this.Controls.Add(this.btnMantenimientoProductos);
            this.Controls.Add(this.btnMantenimientoClientes);
            this.Controls.Add(this.lblOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnMantenimientoClientes;
        private System.Windows.Forms.Button btnMantenimientoProductos;
        private System.Windows.Forms.Button btnFacturación;
        private System.Windows.Forms.Button btnReporteFacturacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}