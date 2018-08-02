namespace FacturacionAplicado.Reportes_Ventanas
{
    partial class Facturas
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
            this.FacturacrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FacturacrystalReportViewer
            // 
            this.FacturacrystalReportViewer.ActiveViewIndex = -1;
            this.FacturacrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacturacrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacturacrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturacrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturacrystalReportViewer.Name = "FacturacrystalReportViewer";
            this.FacturacrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.FacturacrystalReportViewer.TabIndex = 0;
            this.FacturacrystalReportViewer.Load += new System.EventHandler(this.FacturacrystalReportViewer_Load);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FacturacrystalReportViewer);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FacturacrystalReportViewer;
    }
}