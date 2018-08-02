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
    public partial class ReporteProductos : Form
    {
        List<Producto> datos = new List<Producto>();
        public ReporteProductos(List<Producto> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void ProductoscrystalReportViewer_Load(object sender, EventArgs e)
        {
            ProductosReporte abrir = new ProductosReporte();
            abrir.SetDataSource(datos);
            ProductoscrystalReportViewer.ReportSource = abrir;
            ProductoscrystalReportViewer.Refresh();
        }
    }
}
