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
    public partial class ReporteDepartamentos : Form
    {
        List<Departamento> datos = new List<Departamento>();
        public ReporteDepartamentos(List<Departamento> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void DepartamentoscrystalReportViewer_Load(object sender, EventArgs e)
        {
            DepartamentoReporte abrir = new DepartamentoReporte();
            abrir.SetDataSource(datos);
            DepartamentoscrystalReportViewer.ReportSource = abrir;
            DepartamentoscrystalReportViewer.Refresh();
        }
    }
}
