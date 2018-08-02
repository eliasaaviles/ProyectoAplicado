namespace FacturacionAplicado.UI.Consultas
{
    partial class CFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFactura));
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.TexterrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreditocheckBox = new System.Windows.Forms.CheckBox();
            this.ContadocheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexterrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(5, 83);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(874, 415);
            this.ConsultadataGridView.TabIndex = 28;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(2, 7);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(29, 13);
            this.Tipo.TabIndex = 29;
            this.Tipo.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(151, 23);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(157, 20);
            this.CriteriotextBox.TabIndex = 1;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "ID",
            "ClienteId",
            "UsuarioId",
            "Descripcion",
            "Listar Todo",
            "Monto",
            "EfectivoRecibido",
            "Devuelta"});
            this.TipocomboBox.Location = new System.Drawing.Point(5, 23);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(128, 21);
            this.TipocomboBox.TabIndex = 0;
            this.TipocomboBox.SelectedIndexChanged += new System.EventHandler(this.TipocomboBox_SelectedIndexChanged);
            // 
            // Consultabutton
            // 
            this.Consultabutton.Image = global::FacturacionAplicado.Properties.Resources.icons8_Report_Card32_32;
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(347, 9);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(127, 58);
            this.Consultabutton.TabIndex = 2;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // Reportebutton
            // 
            this.Reportebutton.Image = global::FacturacionAplicado.Properties.Resources.icons8_Print_32;
            this.Reportebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportebutton.Location = new System.Drawing.Point(510, 9);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(127, 58);
            this.Reportebutton.TabIndex = 3;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // TexterrorProvider
            // 
            this.TexterrorProvider.ContainerControl = this;
            // 
            // CreditocheckBox
            // 
            this.CreditocheckBox.AutoSize = true;
            this.CreditocheckBox.Location = new System.Drawing.Point(12, 50);
            this.CreditocheckBox.Name = "CreditocheckBox";
            this.CreditocheckBox.Size = new System.Drawing.Size(59, 17);
            this.CreditocheckBox.TabIndex = 39;
            this.CreditocheckBox.Text = "Credito";
            this.CreditocheckBox.UseVisualStyleBackColor = true;
            // 
            // ContadocheckBox
            // 
            this.ContadocheckBox.AutoSize = true;
            this.ContadocheckBox.Location = new System.Drawing.Point(77, 50);
            this.ContadocheckBox.Name = "ContadocheckBox";
            this.ContadocheckBox.Size = new System.Drawing.Size(66, 17);
            this.ContadocheckBox.TabIndex = 40;
            this.ContadocheckBox.Text = "Contado";
            this.ContadocheckBox.UseVisualStyleBackColor = true;
            // 
            // CFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.ContadocheckBox);
            this.Controls.Add(this.CreditocheckBox);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConsultadataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CFactura";
            this.Text = "Consulta de Factura";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexterrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.Button Reportebutton;
        private System.Windows.Forms.ErrorProvider TexterrorProvider;
        private System.Windows.Forms.CheckBox ContadocheckBox;
        private System.Windows.Forms.CheckBox CreditocheckBox;
    }
}