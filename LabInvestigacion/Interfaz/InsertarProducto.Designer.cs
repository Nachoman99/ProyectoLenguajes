namespace Interfaz
{
    partial class InsertarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 45;
            // 
            // btBack
            // 
            this.btBack.AutoSize = true;
            this.btBack.Location = new System.Drawing.Point(11, 222);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(79, 29);
            this.btBack.TabIndex = 44;
            this.btBack.Text = "Atras";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // btInsert
            // 
            this.btInsert.AutoSize = true;
            this.btInsert.Location = new System.Drawing.Point(331, 230);
            this.btInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 29);
            this.btInsert.TabIndex = 43;
            this.btInsert.Text = "Insertar";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(175, 154);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(229, 20);
            this.txbPrice.TabIndex = 42;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(175, 105);
            this.txbDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(229, 20);
            this.txbDesc.TabIndex = 41;
            this.txbDesc.TextChanged += new System.EventHandler(this.txbDesc_TextChanged);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(175, 195);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(231, 20);
            this.txbQuantity.TabIndex = 40;
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(175, 61);
            this.txbCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(229, 20);
            this.txbCode.TabIndex = 39;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(8, 198);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(163, 13);
            this.lblCorreo.TabIndex = 38;
            this.lblCorreo.Text = "Inserte la Cantidad en Inventario:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(39, 157);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(132, 13);
            this.lblapellido.TabIndex = 37;
            this.lblapellido.Text = "Inserte el Precio de Venta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 108);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 13);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Inserte la Descripción:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(82, 64);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(89, 13);
            this.lblCedula.TabIndex = 35;
            this.lblCedula.Text = "Inserte el Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Agregar Producto";
            // 
            // InsertarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InsertarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertarProducto_FormClosing_1);
            this.Load += new System.EventHandler(this.InsertarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label3;
    }
}