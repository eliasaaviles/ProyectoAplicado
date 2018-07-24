using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Registros
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
            foreach (var item in BLL.UsuarioBLL.Buscar())
            {

                IDcomboBox.Items.Add(item.id);
            }
        }

        private void rUsuario_Load(object sender, EventArgs e)
        {

        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
