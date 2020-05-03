namespace Interfaz
{
    partial class ConsultarCliente
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(713, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(12, 12);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersWidth = 51;
            this.dtgCliente.RowTemplate.Height = 24;
            this.dtgCliente.Size = new System.Drawing.Size(776, 397);
            this.dtgCliente.TabIndex = 1;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.btnVolver);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarCliente_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgCliente;
    }
}