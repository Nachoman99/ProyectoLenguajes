namespace LabInvestigacion.Interfaz
{
    partial class InsertarCliente
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(13, 13);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(116, 17);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Inserte la cédula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Inserte el nombre:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(13, 128);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(123, 17);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Inserte el apellido:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(13, 194);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(115, 17);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Inserte el correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 254);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(187, 17);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Inserte el número telefónico:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(136, 13);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(180, 22);
            this.txtCedula.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(143, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(135, 194);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 22);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(207, 254);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.Location = new System.Drawing.Point(358, 411);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 27);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // InsertarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Name = "InsertarCliente";
            this.Text = "Insertar Cliente";
            this.Load += new System.EventHandler(this.InsertarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnInsertar;
    }
}