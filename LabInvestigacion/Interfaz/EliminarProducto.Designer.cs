namespace Interfaz
{
    partial class EliminarProducto
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 189);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 0;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(208, 189);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(93, 41);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(190, 20);
            this.txbCode.TabIndex = 2;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(90, 79);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inserte Código:";
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDelete);
            this.Name = "EliminarProducto";
            this.Text = "Eliminar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarProducto_FormClosing);
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label2;
    }
}