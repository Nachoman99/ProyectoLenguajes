namespace LabInvestigacion.Interfaz
{
    partial class ReporteFacturacion
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
            this.btVolver = new System.Windows.Forms.Button();
            this.txbCheck = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFactura = new System.Windows.Forms.TextBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.mCalentarStart = new System.Windows.Forms.MonthCalendar();
            this.mCalentarEnd = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.AutoSize = true;
            this.btVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btVolver.Location = new System.Drawing.Point(995, 395);
            this.btVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(58, 27);
            this.btVolver.TabIndex = 0;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txbCheck
            // 
            this.txbCheck.Location = new System.Drawing.Point(16, 37);
            this.txbCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCheck.Name = "txbCheck";
            this.txbCheck.Size = new System.Drawing.Size(176, 22);
            this.txbCheck.TabIndex = 2;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(16, 10);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(148, 24);
            this.lbCliente.TabIndex = 10;
            this.lbCliente.Text = "Código Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Facturas";
            // 
            // txbFactura
            // 
            this.txbFactura.Location = new System.Drawing.Point(21, 105);
            this.txbFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFactura.Multiline = true;
            this.txbFactura.Name = "txbFactura";
            this.txbFactura.ReadOnly = true;
            this.txbFactura.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbFactura.Size = new System.Drawing.Size(323, 318);
            this.txbFactura.TabIndex = 12;
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(207, 37);
            this.btVerificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(100, 25);
            this.btVerificar.TabIndex = 13;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // mCalentarStart
            // 
            this.mCalentarStart.Location = new System.Drawing.Point(372, 105);
            this.mCalentarStart.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mCalentarStart.Name = "mCalentarStart";
            this.mCalentarStart.TabIndex = 14;
            // 
            // mCalentarEnd
            // 
            this.mCalentarEnd.Location = new System.Drawing.Point(727, 105);
            this.mCalentarEnd.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mCalentarEnd.Name = "mCalentarEnd";
            this.mCalentarEnd.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(957, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Inicio";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(315, 42);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 18;
            // 
            // ReporteFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1075, 439);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mCalentarEnd);
            this.Controls.Add(this.mCalentarStart);
            this.Controls.Add(this.btVerificar);
            this.Controls.Add(this.txbFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.txbCheck);
            this.Controls.Add(this.btVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReporteFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Facturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReporteFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.ReporteFacturacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.TextBox txbCheck;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFactura;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.MonthCalendar mCalentarStart;
        private System.Windows.Forms.MonthCalendar mCalentarEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbError;
    }
}