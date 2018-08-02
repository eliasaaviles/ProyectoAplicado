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
    public partial class ReporteUsuarios : Form
    {
        List<Usuario> datos = new List<Usuario>();
        public ReporteUsuarios(List<Usuario> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void UsuariocrystalReportViewer_Load(object sender, EventArgs e)
        {
            UsuarioReporte abrir = new UsuarioReporte();
            abrir.SetDataSource(datos);
            UsuariocrystalReportViewer.ReportSource = abrir;
            UsuariocrystalReportViewer.Refresh();
        }
    }
}
