using FacturacionAplicado.Entidades;
using FacturacionAplicado.Reportes_Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Consultas
{
    public partial class Cusuario : Form
    {
        public Cusuario()
        {
            InitializeComponent();
        }
        List<Usuario> lista = new List<Usuario>();
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            

            if (TipocomboBox.Text == string.Empty && CriteriotextBox.Text == string.Empty)
            {
                lista = BLL.UsuarioBLL.Buscar();
            }




            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:

                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;
                    }
                    lista = BLL.UsuarioBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                ////Nombre
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    lista = BLL.UsuarioBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                ////Lista todo
                case 2:
                    LimpiarError();

                    lista = BLL.UsuarioBLL.Buscar();

                    break;
                ////Usuario
                case 3:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un Caracter");
                        return;
                    }
                    lista = BLL.UsuarioBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                ////Clave
                case 4:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    lista = BLL.UsuarioBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                ////Comentario
                case 5:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    lista = BLL.UsuarioBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
            }


            ConsultadataGridView.DataSource = lista;
        }
        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            TexterrorProvider.Clear();
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
                lista = BLL.UsuarioBLL.Buscar();
            ReporteUsuarios abrir = new ReporteUsuarios(lista);
            abrir.Show();
        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.Clear();
            LimpiarError();
            if (TipocomboBox.SelectedIndex == 2)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }

      
    }
}
