
using FacturacionAplicado.Entidades;
using FacturacionAplicado.UI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace facturacionaplicado
{
    public partial class rLogin : Form
    {
        public rLogin()
        {
            InitializeComponent();
            FacturacionAplicado.ConexionGlobal.ConexionGlobalDb.TestConnectiong();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            int paso = 0;
            Expression<Func<Usuario, bool>> filtrar = x => true;
            List<Usuario> user = new List<Usuario>();

            limpiarError();
            
            if (UsuariologtextBox.Text == string.Empty)
            {
                paso = 1;
                LogInerrorProvider.SetError(UsuariologtextBox, "Incorrecto");

            }
            if (ClavetextBox.Text == string.Empty)
            {
                paso = 1;
                LogInerrorProvider.SetError(ClavetextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }

            
            user = FacturacionAplicado.BLL.UsuarioBLL.Getlist("NombreUsuario", UsuariologtextBox.Text);

            if (user.Exists(x => x.NombreUsuario == UsuariologtextBox.Text) && user.Exists(x => x.Clave == ClavetextBox.Text))
            {
                foreach (var item in FacturacionAplicado.BLL.UsuarioBLL.Getlist("NombreUsuario",UsuariologtextBox.Text))
                {
                    FacturacionAplicado.BLL.FacturacionBLL.NombreLogin(item.Nombre,item.id);
                }

                MenuMasVentas abrir = new MenuMasVentas();
                abrir.Show();
                UsuariologtextBox.Clear();
                ClavetextBox.Clear();



            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                LogInerrorProvider.SetError(ClavetextBox, "Incorrecto");
                LogInerrorProvider.SetError(UsuariologtextBox, "Incorrecto");

            }
            ClavetextBox.MaxLength = 14;
           

        }

        void limpiarError()
        {
            LogInerrorProvider.Clear();
            LogInerrorProvider.Clear();
        }
    }
    
}
