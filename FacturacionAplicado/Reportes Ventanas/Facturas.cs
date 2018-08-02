using FacturacionAplicado.Entidades;
using FacturacionAplicado.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionAplicado.Reportes_Ventanas
{
    public partial class Facturas : Form
    {
        List<Factura> datos = new List<Factura>();
        public Facturas(List<Factura> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void FacturacrystalReportViewer_Load(object sender, EventArgs e)
        {
            FacturaReporte abrir = new FacturaReporte();
            abrir.SetDataSource(datos);
            FacturacrystalReportViewer.ReportSource = abrir;
            FacturacrystalReportViewer.Refresh();
        }
    }
}
