namespace Interfaz
{
    partial class AgregarProductos
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
            this.btnAgregarProduct = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.lblListProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(488, 300);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarProduct
            // 
            this.btnAgregarProduct.Location = new System.Drawing.Point(337, 300);
            this.btnAgregarProduct.Name = "btnAgregarProduct";
            this.btnAgregarProduct.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarProduct.TabIndex = 14;
            this.btnAgregarProduct.Text = "Agregar Producto";
            this.btnAgregarProduct.UseVisualStyleBackColor = true;
            this.btnAgregarProduct.Click += new System.EventHandler(this.btnAgregarProduct_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(192, 261);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(37, 261);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(95, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Inserte la Cantidad";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(192, 229);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 11;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(37, 236);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(149, 13);
            this.lblProductID.TabIndex = 10;
            this.lblProductID.Text = "Inserte el Codigo del Producto";
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Location = new System.Drawing.Point(40, 84);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.ReadOnly = true;
            this.dgvListProducts.Size = new System.Drawing.Size(476, 125);
            this.dgvListProducts.TabIndex = 9;
            this.dgvListProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProducts_CellContentClick);
            // 
            // lblListProducts
            // 
            this.lblListProducts.AutoSize = true;
            this.lblListProducts.Location = new System.Drawing.Point(37, 44);
            this.lblListProducts.Name = "lblListProducts";
            this.lblListProducts.Size = new System.Drawing.Size(95, 13);
            this.lblListProducts.TabIndex = 8;
            this.lblListProducts.Text = "Lista de Productos";
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarProduct);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.dgvListProducts);
            this.Controls.Add(this.lblListProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProductos";
            this.Text = "AgregarProductos";
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarProduct;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.Label lblListProducts;
    }
}