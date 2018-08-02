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
    public partial class ReporteClientes : Form
    {
        List<Cliente> datos = new List<Cliente>();
        public ReporteClientes(List<Cliente> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void ClientescrystalReportViewer_Load(object sender, EventArgs e)
        {
            ClientesReporte abrir = new ClientesReporte();
            abrir.SetDataSource(datos);
            ClientescrystalReportViewer.ReportSource = abrir;
            ClientescrystalReportViewer.Refresh();
        }
    }
}
