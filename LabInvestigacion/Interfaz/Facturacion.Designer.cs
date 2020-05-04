namespace LabInvestigacion.Interfaz
{
    partial class Facturacion
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearFact = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblIngreseClientID = new System.Windows.Forms.Label();
            this.txtIngreseClientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Location = new System.Drawing.Point(535, 337);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 19);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearFact
            // 
            this.btnCrearFact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearFact.Location = new System.Drawing.Point(414, 336);
            this.btnCrearFact.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearFact.Name = "btnCrearFact";
            this.btnCrearFact.Size = new System.Drawing.Size(90, 19);
            this.btnCrearFact.TabIndex = 9;
            this.btnCrearFact.Text = "Crear Factura";
            this.btnCrearFact.UseVisualStyleBackColor = true;
            this.btnCrearFact.Click += new System.EventHandler(this.btnCrearFact_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(11, 63);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(96, 23);
            this.btnAgregarProductos.TabIndex = 8;
            this.btnAgregarProductos.Text = "Añadir Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblIngreseClientID
            // 
            this.lblIngreseClientID.AutoSize = true;
            this.lblIngreseClientID.Location = new System.Drawing.Point(8, 9);
            this.lblIngreseClientID.Name = "lblIngreseClientID";
            this.lblIngreseClientID.Size = new System.Drawing.Size(99, 13);
            this.lblIngreseClientID.TabIndex = 7;
            this.lblIngreseClientID.Text = "Ingrese el ClienteID";
            // 
            // txtIngreseClientID
            // 
            this.txtIngreseClientID.Location = new System.Drawing.Point(126, 6);
            this.txtIngreseClientID.Name = "txtIngreseClientID";
            this.txtIngreseClientID.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseClientID.TabIndex = 6;
            this.txtIngreseClientID.TextChanged += new System.EventHandler(this.txtIngreseClientID_TextChanged);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCrearFact);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.lblIngreseClientID);
            this.Controls.Add(this.txtIngreseClientID);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Facturacion";
            this.Text = "Facturación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturacion_FormClosing);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrearFact;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblIngreseClientID;
        private System.Windows.Forms.TextBox txtIngreseClientID;
    }
}