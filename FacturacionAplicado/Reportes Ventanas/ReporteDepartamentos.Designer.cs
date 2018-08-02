namespace FacturacionAplicado.Reportes_Ventanas
{
    partial class ReporteDepartamentos
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
            this.DepartamentoscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DepartamentoscrystalReportViewer
            // 
            this.DepartamentoscrystalReportViewer.ActiveViewIndex = -1;
            this.DepartamentoscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartamentoscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DepartamentoscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartamentoscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DepartamentoscrystalReportViewer.Name = "DepartamentoscrystalReportViewer";
            this.DepartamentoscrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.DepartamentoscrystalReportViewer.TabIndex = 0;
            this.DepartamentoscrystalReportViewer.Load += new System.EventHandler(this.DepartamentoscrystalReportViewer_Load);
            // 
            // ReporteDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartamentoscrystalReportViewer);
            this.Name = "ReporteDepartamentos";
            this.Text = "ReporteDepartamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DepartamentoscrystalReportViewer;
    }
}