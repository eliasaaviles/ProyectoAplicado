namespace FacturacionAplicado.Reportes_Ventanas
{
    partial class ReporteClientes
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
            this.ClientescrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClientescrystalReportViewer
            // 
            this.ClientescrystalReportViewer.ActiveViewIndex = -1;
            this.ClientescrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientescrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientescrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientescrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClientescrystalReportViewer.Name = "ClientescrystalReportViewer";
            this.ClientescrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ClientescrystalReportViewer.TabIndex = 0;
            this.ClientescrystalReportViewer.Load += new System.EventHandler(this.ClientescrystalReportViewer_Load);
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientescrystalReportViewer);
            this.Name = "ReporteClientes";
            this.Text = "ReporteClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClientescrystalReportViewer;
    }
}