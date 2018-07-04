using FacturacionAplicado.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FacturacionAplicado.UI.Menu
{
    public partial class MenuMasVentas : Form
    {
        public MenuMasVentas()
        {
            InitializeComponent();
            ConexionGlobal.ConexionGlobalDb.TestConnectiong();
        }
        



        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes abrir = new rClientes();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDepartamento abrir = new rDepartamento();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacturacion abrir = new rFacturacion();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void MenuMasVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
