namespace Interfaz
{
    partial class ConsultaProducto
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
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProduct
            // 
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(12, 12);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.ReadOnly = true;
            this.dtgProduct.Size = new System.Drawing.Size(630, 323);
            this.dtgProduct.TabIndex = 0;
            this.dtgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellContentClick);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(567, 341);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 368);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dtgProduct);
            this.Name = "ConsultaProducto";
            this.Text = "Consulta Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaProducto_FormClosing);
            this.Load += new System.EventHandler(this.ConsultaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.Button btBack;
    }
}