namespace FacturacionAplicado.Reportes_Ventanas
{
    partial class ReporteProductos
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
            this.ProductoscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProductoscrystalReportViewer
            // 
            this.ProductoscrystalReportViewer.ActiveViewIndex = -1;
            this.ProductoscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductoscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductoscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductoscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductoscrystalReportViewer.Name = "ProductoscrystalReportViewer";
            this.ProductoscrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ProductoscrystalReportViewer.TabIndex = 0;
            this.ProductoscrystalReportViewer.Load += new System.EventHandler(this.ProductoscrystalReportViewer_Load);
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductoscrystalReportViewer);
            this.Name = "ReporteProductos";
            this.Text = "ReporteProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductoscrystalReportViewer;
    }
}