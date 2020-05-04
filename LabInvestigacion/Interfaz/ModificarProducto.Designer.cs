namespace Interfaz
{
    partial class ModificarProducto
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
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.btModify = new System.Windows.Forms.Button();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDesc
            // 
            this.txbDesc.Enabled = false;
            this.txbDesc.Location = new System.Drawing.Point(12, 105);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(158, 20);
            this.txbDesc.TabIndex = 1;
            this.txbDesc.Text = "Descripción";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Enabled = false;
            this.txtbPrice.Location = new System.Drawing.Point(12, 131);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(158, 20);
            this.txtbPrice.TabIndex = 2;
            this.txtbPrice.Text = "Precio";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Enabled = false;
            this.txbQuantity.Location = new System.Drawing.Point(12, 157);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(158, 20);
            this.txbQuantity.TabIndex = 3;
            this.txbQuantity.Text = "Cantidad";
            // 
            // btModify
            // 
            this.btModify.Enabled = false;
            this.btModify.Location = new System.Drawing.Point(12, 192);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 5;
            this.btModify.Text = "Modificar";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(12, 35);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(158, 20);
            this.txbCode.TabIndex = 0;
            this.txbCode.Text = "Código";
            this.txbCode.TextChanged += new System.EventHandler(this.txbCode_TextChanged);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(13, 62);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 6;
            this.btCheck.Text = "Comprobar";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(206, 192);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese Un Código de Producto Válido";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarProducto_FormClosing);
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}